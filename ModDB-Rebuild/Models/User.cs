using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModDB_Rebuild.Models {
	public class User {
		public static User User_AnonUser {
			get {
				return new User(User.user_usersRegistered);
			}
		}

		public uint User_ID { get; }
		public string User_EMail { get; }
		public string User_Username { get; }
		private string user_Password;
		public DateTime? User_Birthday { get; }
		public bool User_Newsletter { get; set; }

		private static uint user_usersRegistered = 0;

		private User(uint id) {
			this.User_ID = id;
		}

		public User() : this("", "", "", DateTime.Now, true) {}

		public User(string userEmail, string user_username, string user_password, DateTime? user_birthday, bool user_newsletter) {
			this.User_ID = ++User.user_usersRegistered;
			this.User_EMail = userEmail;
			this.User_Username = user_username;
			this.user_Password = user_password;
			this.User_Birthday = user_birthday;
			this.User_Newsletter = user_newsletter;
		}
	}
}
