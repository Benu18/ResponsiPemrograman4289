using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemograman4289
{
	class Program
	{
		static void Main(string[] args)
		{
			Karyawan karyawana = new Karyawan(1, "190890881", "FADESS", 4000000);
			Karyawan karyawanb = new Karyawan(2, "190890876", "BIMA", 5000000);

			header1();
			CetakGaji(karyawana);
			CetakGaji(karyawanb);

			header2();
			NaikGaji(karyawana);
			NaikGaji(karyawanb);

			Console.ReadKey();
		}

		static void CetakGaji(Karyawan kry)
		{
			Console.WriteLine(kry.No + ". " + kry.Nik + "\t" + kry.Nama + "\t" + kry.GajiBulanan);
		}

		static void NaikGaji(Karyawan kry)
		{
			double naik;
			naik = kry.GajiBulanan * 0.1;
			kry.GajiBulanan = kry.GajiBulanan + naik;
			Console.WriteLine(kry.No + ". " + kry.Nik + "\t" + kry.Nama + "\t" + kry.GajiBulanan);
		}

		static void header1()
		{
			Console.WriteLine("No Nik/Nama\tGaji Bulanan");
			Console.WriteLine("===============================");
		}

		static void header2()
		{
			Console.WriteLine("\n Gaji Dengan Kenaikan 10%");
			Console.WriteLine("No Nik/Nama\tGaji Bulanan");
			Console.WriteLine("===============================");
		}
	}
}