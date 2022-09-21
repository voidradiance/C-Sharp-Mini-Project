using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean looping = true;
            while (looping)
            {
                Console.WriteLine("Pilih nomor soal yang ingin dikerjakan");
                Console.WriteLine("1. Question 1");
                Console.WriteLine("2. Question 2");
                Console.WriteLine("3. Question 3");
                string input = Console.ReadLine();

                if (!input.Trim().Equals("1") && !input.Trim().Equals("2") && !input.Trim().Equals("3"))
                {
                    Console.Clear();
                    Console.WriteLine("Anda harus memilih antara soal 1, 2 atau 3\n");
                    continue;
                }
                else
                {
                    switch (input)
                    {
                        case "1":
                            Console.Clear();
                            looping = true;
                            while (looping)
                            {
                                Console.WriteLine("Pilih option dari nomor 1 - 5\n" +
                                                "1. Formula: (X * Y) + (Z * Y)\n" +
                                                "2. Formula: (X + Y + Z) / X\n" +
                                                "3. Formula: (X - Z) * Y\n" +
                                                "4. Formula: (Y * 2) - (X + Z)\n" +
                                                "5. Formula: Z * (Y - X)\n" +
                                                "Masukan pilihan anda : ");
                                input = Console.ReadLine();

                                if (!input.Trim().Equals("1") && !input.Trim().Equals("2")
                                    && !input.Trim().Equals("3") && !input.Trim().Equals("4")
                                    && !input.Trim().Equals("5"))
                                {
                                    Console.Clear();
                                    Console.WriteLine("Pilihan tidak valid, silahkan masukan kembali\n");
                                    continue;
                                }
                                else
                                {
                                    int nilaiX, nilaiY;
                                    Double nilaiZ, hasil;
                                    string masukan;
                                    switch (input)
                                    {
                                        case "1":
                                            Console.WriteLine("Kamu memilih formula 1");
                                            Console.WriteLine("Input value X dalam bilangan bulat ");
                                            masukan = Console.ReadLine();
                                            while (!int.TryParse(masukan, out nilaiX))
                                            {
                                                Console.WriteLine("Value harus integer, Masukan kembali nilai X = ");
                                                masukan = Console.ReadLine();
                                            }

                                            Console.WriteLine("Input value Y dalam bilangan bulat ");
                                            masukan = Console.ReadLine();
                                            while (!int.TryParse(masukan, out nilaiY))
                                            {
                                                Console.WriteLine("Value harus integer, Masukan kembali nilai Y = ");
                                                masukan = Console.ReadLine();
                                            }

                                            Console.WriteLine("Input value Z dalam bilangan desimal ");
                                            masukan = Console.ReadLine();
                                            while (!double.TryParse(masukan, out nilaiZ))
                                            {
                                                Console.WriteLine("Value harus integer, Masukan kembali nilai Z = ");
                                                masukan = Console.ReadLine();
                                            }

                                            hasil = (nilaiX * nilaiY) + (nilaiZ * nilaiY);
                                            Console.WriteLine($"Hasilnya adalah {hasil}\n");
                                            break;
                                        case "2":
                                            Console.WriteLine("Kamu memilih formula 2");
                                            Console.WriteLine("Input value X dalam bilangan bulat ");
                                            masukan = Console.ReadLine();
                                            while (!int.TryParse(masukan, out nilaiX))
                                            {
                                                Console.WriteLine("Value harus integer, Masukan kembali nilai X = ");
                                                masukan = Console.ReadLine();
                                            }

                                            Console.WriteLine("Input value Y dalam bilangan bulat ");
                                            masukan = Console.ReadLine();
                                            while (!int.TryParse(masukan, out nilaiY))
                                            {
                                                Console.WriteLine("Value harus integer, Masukan kembali nilai Y = ");
                                                masukan = Console.ReadLine();
                                            }

                                            Console.WriteLine("Input value Z dalam bilangan desimal ");
                                            masukan = Console.ReadLine();
                                            while (!double.TryParse(masukan, out nilaiZ))
                                            {
                                                Console.WriteLine("Value harus integer, Masukan kembali nilai Z = ");
                                                masukan = Console.ReadLine();
                                            }

                                            hasil = (nilaiX + nilaiY + nilaiZ) / nilaiX;
                                            Console.WriteLine($"Hasilnya adalah {hasil}\n");
                                            break;
                                        case "3":
                                            Console.WriteLine("Kamu memilih formula 3");
                                            Console.WriteLine("Input value X dalam bilangan bulat ");
                                            masukan = Console.ReadLine();
                                            while (!int.TryParse(masukan, out nilaiX))
                                            {
                                                Console.WriteLine("Value harus integer, Masukan kembali nilai X = ");
                                                masukan = Console.ReadLine();
                                            }

                                            Console.WriteLine("Input value Y dalam bilangan bulat ");
                                            masukan = Console.ReadLine();
                                            while (!int.TryParse(masukan, out nilaiY))
                                            {
                                                Console.WriteLine("Value harus integer, Masukan kembali nilai Y = ");
                                                masukan = Console.ReadLine();
                                            }

                                            Console.WriteLine("Input value Z dalam bilangan desimal ");
                                            masukan = Console.ReadLine();
                                            while (!double.TryParse(masukan, out nilaiZ))
                                            {
                                                Console.WriteLine("Value harus integer, Masukan kembali nilai Z = ");
                                                masukan = Console.ReadLine();
                                            }

                                            hasil = (nilaiX - nilaiZ) * nilaiY;
                                            Console.WriteLine($"Hasilnya adalah {hasil}\n");
                                            break;
                                        case "4":
                                            Console.WriteLine("Kamu memilih formula 4");
                                            Console.WriteLine("Input value X dalam bilangan bulat ");
                                            masukan = Console.ReadLine();
                                            while (!int.TryParse(masukan, out nilaiX))
                                            {
                                                Console.WriteLine("Value harus integer, Masukan kembali nilai X = ");
                                                masukan = Console.ReadLine();
                                            }

                                            Console.WriteLine("Input value Y dalam bilangan bulat ");
                                            masukan = Console.ReadLine();
                                            while (!int.TryParse(masukan, out nilaiY))
                                            {
                                                Console.WriteLine("Value harus integer, Masukan kembali nilai Y = ");
                                                masukan = Console.ReadLine();
                                            }

                                            Console.WriteLine("Input value Z dalam bilangan desimal ");
                                            masukan = Console.ReadLine();
                                            while (!double.TryParse(masukan, out nilaiZ))
                                            {
                                                Console.WriteLine("Value harus integer, Masukan kembali nilai Z = ");
                                                masukan = Console.ReadLine();
                                            }

                                            hasil = (nilaiY * 2) - (nilaiX + nilaiZ);
                                            Console.WriteLine($"Hasilnya adalah {hasil}\n");
                                            break;
                                        case "5":
                                            Console.WriteLine("Kamu memilih formula 5");
                                            Console.WriteLine("Input value X dalam bilangan bulat ");
                                            masukan = Console.ReadLine();
                                            while (!int.TryParse(masukan, out nilaiX))
                                            {
                                                Console.WriteLine("Value harus integer, Masukan kembali nilai X = ");
                                                masukan = Console.ReadLine();
                                            }

                                            Console.WriteLine("Input value Y dalam bilangan bulat ");
                                            masukan = Console.ReadLine();
                                            while (!int.TryParse(masukan, out nilaiY))
                                            {
                                                Console.WriteLine("Value harus integer, Masukan kembali nilai Y = ");
                                                masukan = Console.ReadLine();
                                            }

                                            Console.WriteLine("Input value Z dalam bilangan desimal ");
                                            masukan = Console.ReadLine();
                                            while (!double.TryParse(masukan, out nilaiZ))
                                            {
                                                Console.WriteLine("Value harus integer, Masukan kembali nilai Z = ");
                                                masukan = Console.ReadLine();
                                            }

                                            hasil = nilaiZ * (nilaiY + nilaiX);
                                            Console.WriteLine($"Hasilnya adalah {hasil}\n");
                                            break;
                                    }

                                    Console.WriteLine("Apakah ingin memulai program question 1 lagi? (y/n) :");
                                    input = Console.ReadLine().Trim();

                                    while (!input.ToLower().Equals("y") && !input.ToLower().Equals("n"))
                                    {
                                        Console.Write("hanya menerima (y) atau (n) :");
                                        input = Console.ReadLine().Trim();
                                    }

                                    if (input.ToLower().Equals("y"))
                                    {
                                        Console.Clear();
                                        continue;
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                            }

                            break;
                        case "2":
                            Console.Clear();
                            looping = true;
                            while (looping)
                            {
                                int tahunInt, bulanInt, tanggalInt;

                                Console.WriteLine("Masukan Tahun : ");
                                string masukan = Console.ReadLine();
                                while (!int.TryParse(masukan, out tahunInt) || (tahunInt <= 0))
                                {
                                    Console.WriteLine("Tahun masih salah, masukan lagi : ");
                                    masukan = Console.ReadLine();
                                }

                                Console.WriteLine("Masukan Bulan : ");
                                masukan = Console.ReadLine();
                                while (!int.TryParse(masukan, out bulanInt) || (!(bulanInt > 0 && bulanInt <= 12)))
                                {
                                    Console.WriteLine("Bulan masih salah, masukan lagi : ");
                                    masukan = Console.ReadLine();
                                }

                                int maxTanggal = DateTime.DaysInMonth(tahunInt, bulanInt);

                                Console.WriteLine("Tanggal tertinggi pada {0} {1} ini adalah {2}", DateTimeFormatInfo.CurrentInfo.GetMonthName(bulanInt), tahunInt, maxTanggal);

                                Console.WriteLine("Input Tanggal : ");
                                masukan = Console.ReadLine();
                                while (!int.TryParse(masukan, out tanggalInt) || tanggalInt > maxTanggal || tanggalInt <= 0)
                                {
                                    Console.WriteLine("Tanggal masih salah, masukan lagi : ");
                                    masukan = Console.ReadLine();
                                }

                                DateTime tanggalLengkap = new DateTime(tahunInt, bulanInt, tanggalInt);

                                Console.Clear();

                                Console.WriteLine("Pilih nomor 1 - 3");
                                Console.WriteLine("1. Penambahan Hari");
                                Console.WriteLine("2. Penambahan Bulan");
                                Console.WriteLine("3. Penambahan Tahun");
                                input = Console.ReadLine();

                                if (!input.Trim().Equals("1") && !input.Trim().Equals("2") && !input.Trim().Equals("3"))
                                {
                                    Console.Clear();
                                    Console.WriteLine("Anda harus memilih antara 1, 2 atau 3\n");
                                    continue;
                                }
                                else
                                {
                                    int hari, bulanNew, tahunNew;
                                    switch (input)
                                    {
                                        case "1":
                                            Console.WriteLine("Berapa hari kemudian dari tanggal ini");
                                            masukan = Console.ReadLine();
                                            while (!int.TryParse(masukan, out hari))
                                            {
                                                Console.WriteLine("Jumlah hari harus berupa angka, masukan lagi : ");
                                                masukan = Console.ReadLine();
                                            }

                                            Console.WriteLine("Tanggal input sebelum perubahan : {0}", tanggalLengkap.ToString("dd MMMM yyyy", CultureInfo.GetCultureInfo("id-ID")));
                                            Console.WriteLine("{0} hari kemudian adalah : {1}", hari, tanggalLengkap.AddDays(hari).ToString("dd MMMM yyyy", CultureInfo.GetCultureInfo("id-ID")));

                                            break;
                                        case "2":
                                            Console.WriteLine("Berapa bulan kemudian dari tanggal ini?");
                                            masukan = Console.ReadLine();
                                            while (!int.TryParse(masukan, out bulanNew))
                                            {
                                                Console.WriteLine("Jumlah bulan harus berupa angka, masukan lagi : ");
                                                masukan = Console.ReadLine();
                                            }

                                            Console.WriteLine("Tanggal input sebelum perubahan : {0}", tanggalLengkap.ToString("dd MMMM yyyy"), CultureInfo.GetCultureInfo("id-ID"));
                                            Console.WriteLine("{0} bulan kemudian adalah : {1}", bulanNew, tanggalLengkap.AddMonths(bulanNew).ToString("dd MMMM yyyy"), CultureInfo.GetCultureInfo("id-ID"));

                                            break;
                                        case "3":
                                            Console.WriteLine("Berapa tahun kemudian dari tanggal ini");
                                            masukan = Console.ReadLine();
                                            while (!int.TryParse(masukan, out tahunNew))
                                            {
                                                Console.WriteLine("Jumlah bulan harus berupa angka, masukan lagi : ");
                                                masukan = Console.ReadLine();
                                            }

                                            Console.WriteLine("Tanggal input sebelum perubahan : {0}", tanggalLengkap.ToString("dd MMMM yyyy"), CultureInfo.GetCultureInfo("id-ID"));
                                            Console.WriteLine("{0} tahun kemudian adalah : {1}", tahunNew, tanggalLengkap.AddYears(tahunNew).ToString("dd MMMM yyyy"), CultureInfo.GetCultureInfo("id-ID"));

                                            break;
                                        default:
                                            break;
                                    }

                                    Console.WriteLine("Apakah ingin memulai program question 2 lagi? (y/n) :");
                                    input = Console.ReadLine().Trim();

                                    while (!input.ToLower().Equals("y") && !input.ToLower().Equals("n"))
                                    {
                                        Console.Write("hanya menerima (y) atau (n) :");
                                        input = Console.ReadLine().Trim();
                                    }

                                    if (input.ToLower().Equals("y"))
                                    {
                                        Console.Clear();
                                        continue;
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                            }


                            break;
                        case "3":
                            Console.Clear();
                            int beginX = 0, beginY = 0, endX = 0, endY = 0;
                            int nilaiPerpindahan, pointX, pointY;
                            looping = true;
                            while (looping)
                            {
                                Console.WriteLine("Sebuah drone berada pada koordinate X = 0, Y = 0.");
                                Console.WriteLine("Setiap kali koordinate X bergerak, Y bergerak 3 kalinya.");

                                Console.WriteLine("Berapa kali perpindahan drone?");
                                string masukan = Console.ReadLine();
                                while (!int.TryParse(masukan, out nilaiPerpindahan) || nilaiPerpindahan <= 0)
                                {
                                    Console.WriteLine("Maaf input belum benar, coba lagi ");
                                    Console.WriteLine("Berapa kali perpindahan drone?");
                                    masukan = Console.ReadLine();
                                }

                                Console.WriteLine("Berapa point perpindahan X setiap kali bergerak?");
                                masukan = Console.ReadLine();
                                while (!int.TryParse(masukan, out pointX))
                                {
                                    Console.WriteLine("Maaf input belum benar, coba lagi ");
                                    Console.WriteLine("Berapa point perpindahan X setiap kali bergerak?");
                                    masukan = Console.ReadLine();
                                }

                                pointY = 3 * pointX;

                                for (int i = 0; i < nilaiPerpindahan; i++)
                                {
                                    endX = beginX + pointX;
                                    endY = beginY + pointY;
                                    Console.WriteLine("X bergerak dari {0} ke {1}, Y bergerak dari {2} ke {3}", beginX, endX, beginY, endY);
                                    beginX = endX;
                                    beginY = endY;
                                }

                                Console.WriteLine("Apakah ingin memulai program Question 3 lagi? (y/n) :");
                                input = Console.ReadLine().Trim();

                                while (!input.ToLower().Equals("y") && !input.ToLower().Equals("n"))
                                {
                                    Console.Write("hanya menerima (y) atau (n) :");
                                    input = Console.ReadLine().Trim();
                                }

                                if (input.ToLower().Equals("y"))
                                {
                                    Console.Clear();
                                    continue;
                                }
                                else
                                {
                                    break;
                                }

                            }
                            break;

                        default:
                            break;
                    }
                }
                Console.WriteLine("JALANKAN PROGRAM UTAMA KEMBALI? (y/n) :");
                input = Console.ReadLine().Trim();

                while (!input.ToLower().Equals("y") && !input.ToLower().Equals("n"))
                {
                    Console.Write("hanya menerima (y) atau (n) :");
                    input = Console.ReadLine().Trim();
                }

                if (input.ToLower().Equals("y"))
                {
                    Console.Clear();
                    continue;
                }
                else
                {
                    break;
                }
            }
        }
    }
}
