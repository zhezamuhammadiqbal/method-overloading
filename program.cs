using v28;

Rumus rumus = new Rumus();
Console.WriteLine("Rumus Bujur Sangkar ");
Console.Write("masukkan sisi : ");
int s = Convert.ToInt16(Console.ReadLine());
Console.Write($"luas bujur sangkar dengan s :{s} adalah : ");
Console.WriteLine(rumus.persegi(s));
Console.WriteLine("=================================================");
Console.WriteLine("Rumus Persegi Panjang ");
Console.Write("masukkan p : ");
int p = Convert.ToInt16(Console.ReadLine());
Console.Write("masukkan l : ");
int l = Convert.ToInt16(Console.ReadLine());
Console.Write($"luas persegi panjang dengan p :{p} dan l :{l} adalah : ");
Console.WriteLine(rumus.persegi(p,l));
