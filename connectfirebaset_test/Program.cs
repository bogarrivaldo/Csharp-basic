
using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;
using Firebase.Database;  // Ada error pada bagian ini
using System;

namespace connectfirebasetest
{
    class Hello
    {
        void AdminSDK()
        {
            var pathToKey = "C:/Users/VALDO/Downloads/mydata.json";
            FirebaseApp.Create(new AppOptions
            {
                Credential = GoogleCredential.FromFile(pathToKey),
            });
        }
        void LayananFirebase()
        {

            var FirebaseURL = "https://csharpprogramtest-default-rtdb.firebaseio.com/";
            var defaultInstance = FirebaseDatabase.DefaultInstance;
            defaultInstance.Options.DataBaseUrl = new Url(FirebaseURL);

            // Contoh membaca data dari Realtime Database
            DatabaseReference reference = defaultInstance.GetReference("path/to/your/data");
            var snapshot = await reference.GetValueAsync();

        }
    }
    class Update : Hello
    {
        static void Main(String[] args)
        {
            Update test1 = new Update();
            test1.AdminSDK();
            test1.LayananFirebase();
            Console.Clear();
        }
    }

}

