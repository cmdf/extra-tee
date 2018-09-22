namespace App {
	class Params {

		// data
		/// <summary>
		/// Indicates whether to append to file.
		/// </summary>
		public bool Append;
		/// <summary>
		/// Name of file to write to.
		/// </summary>
		public string File = "";


		// constructor
		/// <summary>
		/// Get parameters from input arguments.
		/// </summary>
		/// <param name="args">Input arguments.</param>
		public Params(string[] args) {
			for (int i = 0; i < args.Length; i++) {
				string a = args[i];
				if (a.StartsWith("--")) { SetOption(a.Substring(2, 1)); continue; }
				if (a.StartsWith("-")) { SetOption(a.Substring(1)); continue; }
				File = a;
			}
		}


		// method
		/// <summary>
		/// Set options from option string.
		/// </summary>
		/// <param name="o">Option string.</param>
		private void SetOption(string o) {
			foreach(char c in o.ToLower()) {
				if (c == 'a') Append = true;
			}
		}
	}
}
