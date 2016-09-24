using System;
using System.IO;

namespace orez.otee {
	class Program {

		// constant
		/// <summary>
		/// Size of read-write buffer.
		/// </summary>
		public const int BUFFER_SIZE = 16 * 1024;


		// static method
		/// <summary>
		/// Loving someone isn’t enough to guarantee we will know how to care for them.
		/// For this, we need to learn to understand the distinctive way in which they
		/// need our love to manifest itself in order for it to feel real to them.
		/// : The School of Life
		/// </summary>
		/// <param name="args">Input arguments.</param>
		static void Main(string[] args) {
			oParams p = new oParams(args);
			char[] buf = new char[BUFFER_SIZE];
			FileMode m = p.Append ? FileMode.Append : FileMode.Create;
			TextWriter f = p.File != "" ? new StreamWriter(File.Open(p.File, m)) : null;
			while (Transfer(Console.Out, f, Console.In, buf) > 0) ;
			if (f != null) f.Close();
		}


		/// <summary>
		/// Transfer text to output writers from input reader.
		/// </summary>
		/// <param name="o0">Text writer 0.</param>
		/// <param name="o1">Text writer 1.</param>
		/// <param name="i0">Text reader 0.</param>
		/// <param name="buf">Read buffer.</param>
		/// <returns>Number of characters transferred.</returns>
		private static int Transfer(TextWriter o0, TextWriter o1, TextReader i0, char[] buf) {
			int r = i0.ReadBlock(buf, 0, buf.Length);
			if (r <= 0) return r;
			if (o0 != null) o0.Write(buf, 0, r);
			if (o1 != null) o1.Write(buf, 0, r);
			return r;
		}
	}
}
