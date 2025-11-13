using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.PeerToPeer;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SolidCP.EnterpriseServer;


public class HostBillServer : HostBillServerInfo
{
	//SystemController SystemController;
	public static HostBillServerInfo GetHostBillIntegration() => SystemController.GetHostBillIntegration();
	#region --- Typed Models ---
	public class HostBillDateConverter : JsonConverter<DateTime>
	{
		public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var str = reader.GetString();
			return DateTime.ParseExact(str, "yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
		}

		public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToString("yyyy-MM-dd HH:mm:ss"));
		}
	}
	public class HostBillUserInfoResponse
	{
		[JsonPropertyName("status")]
		public string Status { get; set; }

		[JsonPropertyName("totalresults")]
		public int TotalResults { get; set; }

		[JsonPropertyName("clients")]
		public List<HostBillClient> Clients { get; set; }
	}

	public class HostBillClientResponse
	{
		[JsonPropertyName("status")]
		public string Status { get; set; }

		[JsonPropertyName("client")]
		public HostBillClient Client { get; set; }
	}
    public class HostBillCreateClientResponse
    {
        [JsonPropertyName("success")]
        public bool Success { get; set; }
        [JsonPropertyName("message")]
        public string Message { get; set; }
        [JsonPropertyName("client_id")]
        public int ClientId { get; set; }
    }
    public class HostBillClient
	{
		[JsonPropertyName("id")]
		public int Id { get; set; }

		[JsonPropertyName("username")]
		public string Username { get; set; }

		[JsonPropertyName("firstname")]
		public string FirstName { get; set; }

		[JsonPropertyName("lastname")]
		public string LastName { get; set; }

		[JsonPropertyName("companyname")]
		public string CompanyName { get; set; }

		[JsonPropertyName("email")]
		public string Email { get; set; }

		[JsonPropertyName("phonenumber")]
		public string PhoneNumber { get; set; }

		[JsonPropertyName("address1")]
		public string Address1 { get; set; }

		[JsonPropertyName("address2")]
		public string Address2 { get; set; }

		[JsonPropertyName("city")]
		public string City { get; set; }

		[JsonPropertyName("state")]
		public string State { get; set; }

		[JsonPropertyName("postcode")]
		public string Postcode { get; set; }

		[JsonPropertyName("country")]
		public string Country { get; set; }

		[JsonPropertyName("datecreated")]
		[JsonConverter(typeof(HostBillDateConverter))]
		public DateTime DateCreated { get; set; }

		[JsonPropertyName("status")]
		public string Status { get; set; }

		[JsonPropertyName("group_id")]
		public string GroupId { get; set; }

		[JsonPropertyName("currency_id")]
		public string CurrencyId { get; set; }

		[JsonPropertyName("brand_id")]
		public string BrandId { get; set; }

		[JsonPropertyName("credit")]
		public string Credit { get; set; }

		[JsonPropertyName("language")]
		public string Language { get; set; }

		[JsonPropertyName("taxexempt")]
		public string TaxExempt { get; set; }

		[JsonPropertyName("defaultgateway")]
		public string DefaultGateway { get; set; }

		[JsonPropertyName("customfields")]
		public Dictionary<string, string> CustomFields { get; set; }

		[JsonExtensionData]
		public Dictionary<string, object> AdditionalData { get; set; }
	}
	public class AuthenticateResponse
	{
		[JsonPropertyName("status")]
		public string Status { get; set; }

		[JsonPropertyName("client")]
		public HostBillClient Client { get; set; }
	}
	#endregion

	public static T CallApi<T>(string cmd, string parameters, Method method = Method.Post) where T : class
	{
		var server = GetHostBillIntegration();
		if (!server.Enabled) return null;

		string apiUrl = $"{server.Url}/api/";
		var data = $"sld={server.Id}&cmd={cmd}&{parameters}";
		// Generate HostBill signature (HMAC-MD5)
		string signature;
		using (var hmac = new HMACMD5(Encoding.UTF8.GetBytes(server.Key)))
		{
			byte[] hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(data));
			signature = BitConverter.ToString(hash).Replace("-", "").ToLower();
		}

		data += $"&hash={signature}";

		var client = new RestClient(apiUrl);
		var request = new RestRequest("", method);
		request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
		request.AddParameter("application/x-www-form-urlencoded", data, ParameterType.RequestBody);

		var response = client.Execute<T>(request);

		if (!response.IsSuccessful) throw new InvalidOperationException($"REST Error: {response.StatusCode}");

		return response.Data;
	}

    public static void CreateHostBillUser(UserInfo user, string password) {
        var server = GetHostBillIntegration();
        if (!server.Enabled) return;

		var client = new HostBillClient()
		{
			Address1 = user.Address,
			City = user.City,
			CompanyName = user.CompanyName,
			Country = user.Country,
			Email = user.Email,
			FirstName = user.FirstName,
			LastName = user.LastName,
			PhoneNumber = user.PrimaryPhone,
			Postcode = user.Zip,
			Username = user.Username,
			CurrencyId = "1", // default currency
			Language = "en", // default language
            AdditionalData = new Dictionary<string, object>()
			{
				{ "password", password }
			}
		};

		var response = CallApi<HostBillCreateClientResponse>("client.create",
			$"username={Uri.EscapeDataString(client.Username)}&firstname={Uri.EscapeDataString(client.FirstName)}&lastname={Uri.EscapeDataString(client.LastName)}&companyname={Uri.EscapeDataString(client.CompanyName)}&email={Uri.EscapeDataString(client.Email)}&phonenumber={Uri.EscapeDataString(client.PhoneNumber)}&address1={Uri.EscapeDataString(client.Address1)}&city={Uri.EscapeDataString(client.City)}&state={Uri.EscapeDataString(client.State)}&postcode={Uri.EscapeDataString(client.Postcode)}&country={Uri.EscapeDataString(client.Country)}&currency_id={Uri.EscapeDataString(client.CurrencyId)}&language={Uri.EscapeDataString(client.Language)}&password={Uri.EscapeDataString(password)}");

		if (!response.Success) throw new InvalidOperationException($"HostBill user creation failed: {response.Message}");
    }

	// returns null on success or error message otherwise
	public static string AuthenticateAndAddHostBillUser(string username, string password)
	{
		var server = GetHostBillIntegration();
		if (!server.Enabled) return null;

		try
		{
			var authResponse = CallApi<AuthenticateResponse>("authenticateclient", $"username={Uri.EscapeDataString(username)}&password={Uri.EscapeDataString(password)}");
			if (authResponse != null && authResponse.Status == "OK")
			{
				var user = authResponse.Client;
				UserController.AddUser(new UserInfo
				{
					Address = user.Address1,
					City = user.City,
					CompanyName = user.CompanyName,
					Country = user.Country,
					Created = user.DateCreated,
					Email = user.Email,
					FirstName = user.FirstName,
					LastName = user.LastName,
					OwnerId = 1,
					PrimaryPhone = user.PhoneNumber,
					State = user.State,
					Role = UserRole.User,
					Zip = user.Postcode,
					Username = username,
				}, false, password, false);
				return null;
			}
			else return authResponse.Status;
		} catch (Exception ex) {
			return ex.Message;
		}
	}
}