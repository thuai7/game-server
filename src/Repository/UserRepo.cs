using Model;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace Repository
{
    public class UserRepo : IUserRepo
    {
        public async Task<List<User>> Query()
        {
            await Task.CompletedTask;

            ///<summary>
            ///Serialize the data
            /// </summary>
            string data = "[{\"Id\":\"001\"}]";
            return JsonConvert.DeserializeObject<List<User>>(data) ?? new List<User>();
        }
    }
}
