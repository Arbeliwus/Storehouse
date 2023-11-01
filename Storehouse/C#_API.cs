using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text;

namespace Storehouse
{
    internal class API
    {
        public static async void PostData(string url, FormUrlEncodedContent payload)//新增
        {
            try
            {
                using var client = new HttpClient();
                var response = await client.PostAsync(url, payload);
                var responseContent = await response.Content.ReadAsStringAsync();
                System.Diagnostics.Debug.WriteLine(responseContent);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }
        public static async void PutData(string url, dynamic payload)//修改
        {
            try
            {
                HttpClient httpClient = new HttpClient();
                var json = JsonConvert.SerializeObject(payload);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await httpClient.PutAsync(url, content);
                System.Diagnostics.Debug.WriteLine(await response.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }
        public static async Task<JArray> GetData(string url)//讀取
        {
            try
            {
                using var client = new HttpClient();
                var response = await client.GetAsync(url);
                var responseContent = await response.Content.ReadAsStringAsync();
                System.Diagnostics.Debug.WriteLine(responseContent);
                if (response.IsSuccessStatusCode)
                    return JArray.Parse(responseContent);
                else
                    return null;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return null;
            }
        }
        public static async void DeleteData(string url,string selectRow_id)
        {
            try
            {
                using var client = new HttpClient();
                var response = await client.DeleteAsync(url + "?id=" + selectRow_id);
                var responseContent = await response.Content.ReadAsStringAsync();
                System.Diagnostics.Debug.WriteLine(responseContent);
            }
            catch(Exception ex) 
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }
        public   static async Task<bool> GetUserInformation_GetData(string url, string account, string password)
        {
            try
            {
                var parameters = new FormUrlEncodedContent(new[]{
                    new KeyValuePair<string,string>("account",account),
                    new KeyValuePair<string,string>("password",password)
                });
                using var client = new HttpClient();
                var response = await client.PostAsync(url, parameters);// 用 HttpClient 進行 POST 請求
                var responseContent = await response.Content.ReadAsStringAsync();// 讀取回應內容
                dynamic json_response = JsonConvert.DeserializeObject(responseContent);//將 JSON 格式轉成動態物件
                Gobal.permissions = json_response.permissions;//帳密錯誤時是null
                Gobal.account = account;
                return json_response.status == "success";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

        }
        public static async void getTickNo_PostData(string url, dynamic payload,ComboBox comboBox)
        {
            try
            {
                using HttpClient client = new HttpClient();
                var response = await client.PostAsync(url, payload);
                var responseContent = await response.Content.ReadAsStringAsync();
                dynamic Json_Response = JsonConvert.DeserializeObject(responseContent);//強型態
                String[] ticketNos = Json_Response.ticketNos.ToObject<String[]>();//將Json陣列轉為array處理
                if (Json_Response.status == "success")
                {
                    Dictionary<int, string> items = new Dictionary<int, string>();
                    for (int i = 0; i < ticketNos.Length; i++)
                        items.Add(i, ticketNos[i]);
                    comboBox.DataSource = new BindingSource(items, null);
                    comboBox.DisplayMember = "Value";   // 要顯示的鍵對應的值
                    comboBox.ValueMember = "Key";       // 鍵的值
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
                comboBox.DataSource = null;
            }
        }
        public static async Task<JArray> getProductDetail_PostData(FormUrlEncodedContent payload)
        {
            try
            {
                const string getProductDetail = "http://localhost/api/getProductDetail.php";
                using HttpClient client = new HttpClient();
                var response = await client.PostAsync(getProductDetail, payload);
                var responseContent = await response.Content.ReadAsStringAsync();
                return JArray.Parse(responseContent);
                
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
