using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Bankamatik_Proje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bakiye = 2500;
            string sifre = "ab18";
        giris:

            Console.WriteLine("Kartlı işlem için 1'i kartsız işlem için 2'yi tuşlayınız");
            string karttercihi = Console.ReadLine();
            if (karttercihi == "1")
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Kartlı işlem bölümüne hoşgeldiniz şifrenizi girmek için 3 hakkınız var eğer yapamazsanız uygulama kapanır.");
                    Console.WriteLine("Kartlı işlem için şifre giriniz(" + (3 - i) + " hakkınız var):");
                    string girilensifre = Console.ReadLine();
                    if (girilensifre == sifre)
                    {
                        Console.WriteLine("Giriş Başarılı");
                        break;

                    }
                    else { Console.WriteLine("Şifre Yanlış"); }
                }
            anamenu:
                Console.WriteLine("***************Ana Menü*****************");
                Console.WriteLine("             Para Çekmek için    1\r\n             Para yatırmak için  2\r\n             Para Transferleri   3\r\n             Eğitim Ödemeleri (Arızalı)    4\r\n             Ödemeler            5\r\n             Bilgi Güncelleme    6");
                string anamenusecim = Console.ReadLine();
                if (anamenusecim == "1")
                {
                    Console.WriteLine("             Bakiye yeterli ise para çekilecek,değilse yetersiz bakiye\r\n     bakiye çekmeye devam etmek için 1\r\n        Ana menüye dönmek için   9\r\n             Çıkmak için             0");
                    string secim1 = Console.ReadLine();
                    if (secim1 == "9")
                    {
                        ; goto anamenu;
                    }

                    if (secim1 == "0")
                    {
                        goto giris;
                    }
                    if (secim1 == "1")
                    {
                        Console.WriteLine("Çekmek istediğiniz para miktarını yazın: ");
                        int cekilmekistenenmiktar = Convert.ToInt32(Console.ReadLine());
                        if (cekilmekistenenmiktar < bakiye)
                        {
                            bakiye = bakiye - cekilmekistenenmiktar;
                            Console.WriteLine(cekilmekistenenmiktar + " kadar para çekildi geri kalan bakiye: " + bakiye);

                        }
                        else
                        {
                            Console.WriteLine("Bakiye yetersiz");
                        }
    ;
                    }

                }
                if (anamenusecim == "2")
                {
                secim2:
                    Console.WriteLine("Kredi Kartına yatırmak için 1'e basın.");
                    Console.WriteLine("Kendi Hesabınıza yatırmak için 2'ye basın.");
                    Console.WriteLine("Ana Menüye dönmek için 9'a basın.");
                    Console.WriteLine("Çıkmak için 0'a basın.");
                    string secim2 = Console.ReadLine();

                    if (secim2 == "1")
                    {
                        // Kredi Kartına Para Yatırma İşlemi
                        Console.WriteLine("Lütfen 12 haneli kart numarasını giriniz: ");
                        string kartNumarasi = Console.ReadLine();

                        if (kartNumarasi.Length == 12)
                        {
                            Console.WriteLine("Yatırmak istediğiniz miktarı giriniz: ");
                            int yatirilacakMiktar = Convert.ToInt32(Console.ReadLine());

                            if (yatirilacakMiktar <= bakiye)
                            {
                                bakiye -= yatirilacakMiktar;
                                Console.WriteLine(yatirilacakMiktar + " TL, kredi kartınıza yatırıldı. Güncel bakiye: " + bakiye + " TL");
                                Console.WriteLine("Ana menüye dönmek için 9'a, çıkmak için 0'a basın.");
                                string secimg = Console.ReadLine();
                                if (secimg == "9")
                                {
                                    goto anamenu;
                                }
                                else if (secimg == "0")
                                {
                                    goto giris;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Bakiye yetersiz.");
                                Console.WriteLine("Ana menüye dönmek için 9'a, çıkmak için 0'a basın.");
                                string secimg = Console.ReadLine();
                                if (secimg == "9")
                                {
                                    goto anamenu;
                                }
                                else if (secimg == "0")
                                {
                                    goto giris;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Hatalı kart numarası. Lütfen 12 haneli bir numara giriniz.");
                            goto secim2;
                        }
                    }
                    else if (secim2 == "2")
                    {
                        Console.WriteLine("Yatırmak istediğiniz miktarı giriniz: ");
                        int yatirilacakMiktar = Convert.ToInt32(Console.ReadLine());
                        bakiye += yatirilacakMiktar;
                        Console.WriteLine(yatirilacakMiktar + " TL hesabınıza yatırıldı. Güncel bakiye: " + bakiye + " TL");
                    }
                    else if (secim2 == "9")
                    {
                        goto anamenu;
                    }
                    else if (secim2 == "0")
                    {
                        goto giris;
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz bir seçim yaptınız.");
                        goto secim2;
                    }

                    Console.WriteLine("Ana menüye dönmek için 9'a, çıkmak için 0'a basın.");
                    string secimSon = Console.ReadLine();
                    if (secimSon == "9")
                    {
                        goto anamenu;
                    }
                    else if (secimSon == "0")
                    {
                        goto giris;
                    }
                }
                if (anamenusecim == "3")
                {
                secim3:
                    Console.WriteLine("Başka Hesaba EFT için 1'e, Başka Hesaba Havale için 2'ye basın. Ana menüye dönmek için 9u çıkış yapmak için 0ı tuşlayın ");
                    string secim3 = Console.ReadLine();
                    if (secim3 == "9")
                    {
                        goto anamenu;
                    }
                    else if (secim3 == "0")
                    {
                        goto giris;
                    }
                    if (secim3 == "1")
                    {
                        Console.WriteLine("Lütfen EFT numarasını giriniz (başında 'tr' olmalı ve 12 haneli sayı olmalı): ");
                        string eftNumarasi = Console.ReadLine();

                        if (eftNumarasi.StartsWith("tr") && eftNumarasi.Length == 14)
                        {
                            Console.WriteLine("Yatırmak istediğiniz miktarı giriniz: ");
                            int eftMiktari = Convert.ToInt32(Console.ReadLine());

                            if (eftMiktari <= bakiye)
                            {
                                bakiye -= eftMiktari;
                                Console.WriteLine(eftMiktari + " TL başka hesaba EFT ile gönderildi. Güncel bakiye: " + bakiye + " TL");
                                Console.WriteLine("Ana menüye dönmek için 9'a, çıkmak için 0'a basın.");
                                string secimSon = Console.ReadLine();
                                if (secimSon == "9")
                                {
                                    goto anamenu;
                                }
                                else if (secimSon == "0")
                                {
                                    goto giris;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Bakiye yetersiz.");
                                Console.WriteLine("Ana menüye dönmek için 9'a, çıkmak için 0'a basın.");
                                string secimSon = Console.ReadLine();
                                if (secimSon == "9")
                                {
                                    goto anamenu;
                                }
                                else if (secimSon == "0")
                                {
                                    goto giris;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Hatalı EFT numarası. Lütfen tekrar deneyin.");
                            Console.WriteLine("Ana menüye dönmek için 9'a, çıkmak için 0'a basın. Yada eft nuamarasını tekrar girmek isterseniz 1'e basın");
                            string secimSon = Console.ReadLine();
                            if (secimSon == "9")
                            {
                                goto anamenu;
                            }
                            else if (secimSon == "0")
                            {
                                goto giris;
                            }
                            else if (secimSon == "1") { goto secim3; }

                        }

                    }
                    else if (secim3 == "2")
                    {
                        Console.WriteLine("Lütfen havale yapmak istediğiniz hesap numarasını giriniz (11 haneli olmalı");
                        string havalenumarasi = Console.ReadLine();
                        if (havalenumarasi.Length == 11)
                        {
                            Console.WriteLine("Göndermek istediğiniz miktarı giriniz: ");
                            int havaleMiktari = Convert.ToInt32(Console.ReadLine());

                            if (havaleMiktari <= bakiye)
                            {
                                bakiye -= havaleMiktari;
                                Console.WriteLine(havaleMiktari + " TL başka hesaba havale ile gönderildi. Güncel bakiye: " + bakiye + " TL");
                                Console.WriteLine("Ana menüye dönmek için 9'a, çıkmak için 0'a basın.");
                                string secimSon = Console.ReadLine();

                                if (secimSon == "9")
                                {
                                    goto anamenu;
                                }
                                else if (secimSon == "0")
                                {
                                    goto giris;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Bakiye yetersiz.");
                                Console.WriteLine("Ana menüye dönmek için 9'a, çıkmak için 0'a basın.");
                                string secimSon = Console.ReadLine();

                                if (secimSon == "9")
                                {
                                    goto anamenu;
                                }
                                else if (secimSon == "0")
                                {
                                    goto giris;
                                }
                            }
                        }
                        else { Console.WriteLine("Hatalı havale numarası. Lütfen tekrar deneyin."); goto secim3; }

                    }
                }
                    if (anamenusecim == "4")
                    {
                        Console.WriteLine("Bu sayfa arızalı");
                        Console.WriteLine("Ana menüye dönmek için 9'a, çıkmak için 0'a basın.");
                        string secimSon = Console.ReadLine();
                        if (secimSon == "9")
                        {
                            goto anamenu;
                        }
                        else if (secimSon == "0")
                        {
                            goto giris;
                        }
                    }



                if (anamenusecim == "5")
                {
                secim5:
                    Console.WriteLine("Fatura ödemeleri için seçenekler:");
                    Console.WriteLine("1: Elektrik Faturası");
                    Console.WriteLine("2: Telefon Faturası");
                    Console.WriteLine("3: İnternet Faturası");
                    Console.WriteLine("4: Su Faturası");
                    Console.WriteLine("5: OGS Ödemeleri");
                    Console.WriteLine("9: Ana Menüye Dön");
                    Console.WriteLine("0: Çıkış");
                    string secim5 = Console.ReadLine();

                    if (secim5 == "9")
                    {
                        goto anamenu;
                    }
                    else if (secim5 == "0")
                    {
                        goto giris;
                    }
                    else if (secim5 == "1")
                    {
                        Console.WriteLine("Elektrik faturası tutarını giriniz: ");
                        int faturaTutari = Convert.ToInt32(Console.ReadLine());

                        if (faturaTutari <= bakiye)
                        {
                            bakiye -= faturaTutari;
                            Console.WriteLine(faturaTutari + " TL elektrik faturası ödendi. Güncel bakiye: " + bakiye + " TL");
                        }
                        else
                        {
                            Console.WriteLine("Bakiye yetersiz.");
                        }

                        Console.WriteLine("Ana Menüye dönmek için 9'a, çıkmak için 0'a basın.");
                        string secimSon = Console.ReadLine();
                        if (secimSon == "9")
                        {
                            goto anamenu;
                        }
                        else if (secimSon == "0")
                        {
                            goto giris;
                        }
                    }
                    else if (secim5 == "2")
                    {
                        Console.WriteLine("Telefon faturası tutarını giriniz: ");
                        int faturaTutari = Convert.ToInt32(Console.ReadLine());

                        if (faturaTutari <= bakiye)
                        {
                            bakiye -= faturaTutari;
                            Console.WriteLine(faturaTutari + " TL telefon faturası ödendi. Güncel bakiye: " + bakiye + " TL");
                        }
                        else
                        {
                            Console.WriteLine("Bakiye yetersiz.");
                        }

                        Console.WriteLine("Ana Menüye dönmek için 9'a, çıkmak için 0'a basın.");
                        string secimSon = Console.ReadLine();
                        if (secimSon == "9")
                        {
                            goto anamenu;
                        }
                        else if (secimSon == "0")
                        {
                            goto giris;
                        }
                    }
                    else if (secim5 == "3")
                    {
                        Console.WriteLine("İnternet faturası tutarını giriniz: ");
                        int faturaTutari = Convert.ToInt32(Console.ReadLine());

                        if (faturaTutari <= bakiye)
                        {
                            bakiye -= faturaTutari;
                            Console.WriteLine(faturaTutari + " TL internet faturası ödendi. Güncel bakiye: " + bakiye + " TL");
                        }
                        else
                        {
                            Console.WriteLine("Bakiye yetersiz.");
                        }

                        Console.WriteLine("Ana Menüye dönmek için 9'a, çıkmak için 0'a basın.");
                        string secimSon = Console.ReadLine();
                        if (secimSon == "9")
                        {
                            goto anamenu;
                        }
                        else if (secimSon == "0")
                        {
                            goto giris;
                        }
                    }
                    else if (secim5 == "4")
                    {
                        Console.WriteLine("Su faturası tutarını giriniz: ");
                        int faturaTutari = Convert.ToInt32(Console.ReadLine());

                        if (faturaTutari <= bakiye)
                        {
                            bakiye -= faturaTutari;
                            Console.WriteLine(faturaTutari + " TL su faturası ödendi. Güncel bakiye: " + bakiye + " TL");
                        }
                        else
                        {
                            Console.WriteLine("Bakiye yetersiz.");
                        }

                        Console.WriteLine("Ana Menüye dönmek için 9'a, çıkmak için 0'a basın.");
                        string secimSon = Console.ReadLine();
                        if (secimSon == "9")
                        {
                            goto anamenu;
                        }
                        else if (secimSon == "0")
                        {
                            goto giris;
                        }
                    }
                    else if (secim5 == "5")
                    {
                        Console.WriteLine("OGS ödemesi tutarını giriniz: ");
                        int faturaTutari = Convert.ToInt32(Console.ReadLine());

                        if (faturaTutari <= bakiye)
                        {
                            bakiye -= faturaTutari;
                            Console.WriteLine(faturaTutari + " TL OGS ödemesi yapıldı. Güncel bakiye: " + bakiye + " TL");
                        }
                        else
                        {
                            Console.WriteLine("Bakiye yetersiz.");
                        }

                        Console.WriteLine("Ana Menüye dönmek için 9'a, çıkmak için 0'a basın.");
                        string secimSon = Console.ReadLine();
                        if (secimSon == "9")
                        {
                            goto anamenu;
                        }
                        else if (secimSon == "0")
                        {
                            goto giris;
                        }
                        else
                        {
                            Console.WriteLine("Geçersiz bir seçim yaptınız.");
                            goto secim5;
                        }
                    }
                }
                    if (anamenusecim == "6")
                    {
                        Console.WriteLine("Şifre değiştirmek için 1'e basın.");
                        string secim6 = Console.ReadLine();

                        if (secim6 == "1")
                        {
                            Console.WriteLine("Mevcut şifrenizi giriniz:");
                            string mevcutSifre = Console.ReadLine();

                            if (mevcutSifre == sifre)
                            {
                                Console.WriteLine("Yeni şifrenizi giriniz:");
                                string yeniSifre = Console.ReadLine();
                                sifre = yeniSifre;
                                Console.WriteLine("Şifreniz başarıyla değiştirildi.");
                            }
                            else
                            {
                                Console.WriteLine("Mevcut şifre hatalı.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Geçersiz seçim. Ana menüye dönmek için 9'a, çıkmak için 0'a basın.");
                        }

                        Console.WriteLine("Ana menüye dönmek için 9'a, çıkmak için 0'a basın.");
                        string secimSon = Console.ReadLine();
                        if (secimSon == "9")
                        {
                            goto anamenu;
                        }
                        else if (secimSon == "0")
                        {
                            goto giris;
                        }
                    }



                
                Console.ReadLine();
            }
            else if (karttercihi == "2")
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Kartlı işlem bölümüne hoşgeldiniz şifrenizi girmek için 3 hakkınız var eğer yapamazsanız uygulama kapanır.");
                    Console.WriteLine("Kartlı işlem için şifre giriniz(" + (3 - i) + " hakkınız var):");
                    string girilensifre = Console.ReadLine();
                    if (girilensifre == sifre)
                    {
                        Console.WriteLine("Giriş Başarılı");
                        break;

                    }
                    else { Console.WriteLine("Şifre Yanlış"); }
                }
            anamenukartsız:
                Console.WriteLine("***************Ana Menü*****************");
                Console.WriteLine("CepBank Para Çekmek 1\r\n             Para yatırmak için  2\r\n             Kredi Kartı Ödeme   3\r\n             Eğitim Ödemeleri    4\r\n             Ödemeler            5");
                string anamenusecim = Console.ReadLine();
                if (anamenusecim == "1")
                {
                    for (int i = 1; i <= 3; i++)
                    {
                        Console.WriteLine("TC'nizi girin: ");
                        string tc = Console.ReadLine();
                        Console.WriteLine("Telefon Numaranızı girin: ");
                        string telno = Console.ReadLine();

                        if (telno == "5550005500" && tc == "11111111111")
                        {
                            bakiye += 1000;
                            Console.WriteLine("Başarıyla giriş yapıldı. Bakiye güncellendi. Ana Menüye yönlendiriliyorsunuz.");
                            goto anamenukartsız;
                        }
                        else
                        {
                            Console.WriteLine("Geçersiz bilgiler. Deneme hakkınız = " + (3 - i));
                        }
                    }

                    Console.WriteLine("1 saat bekleniyor...");
                    Thread.Sleep(3600000);
                    Console.WriteLine("Bekleme süresi sona erdi.");
                    goto anamenukartsız;



                }
                if (anamenusecim == "2")
                {
                secim2:
                    Console.WriteLine("Kredi Kartına yatırmak için 1'e basın.");
                    Console.WriteLine("Kendi Hesabınıza yatırmak için 2'ye basın.");
                    Console.WriteLine("Ana Menüye dönmek için 9'a basın.");
                    Console.WriteLine("Çıkmak için 0'a basın.");
                    string secim2 = Console.ReadLine();

                    if (secim2 == "1")
                    {
                        // Kredi Kartına Para Yatırma İşlemi
                        Console.WriteLine("Lütfen 12 haneli kart numarasını giriniz: ");
                        string kartNumarasi = Console.ReadLine();

                        if (kartNumarasi.Length == 12)
                        {
                            Console.WriteLine("Yatırmak istediğiniz miktarı giriniz: ");
                            int yatirilacakMiktar = Convert.ToInt32(Console.ReadLine());

                            if (yatirilacakMiktar <= bakiye)
                            {
                                bakiye -= yatirilacakMiktar;
                                Console.WriteLine(yatirilacakMiktar + " TL, kredi kartınıza yatırıldı. Güncel bakiye: " + bakiye + " TL");
                                Console.WriteLine("Ana menüye dönmek için 9'a, çıkmak için 0'a basın.");
                                string secimg = Console.ReadLine();
                                if (secimg == "9")
                                {
                                    goto anamenukartsız;
                                }
                                else if (secimg == "0")
                                {
                                    goto giris;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Bakiye yetersiz.");
                                Console.WriteLine("Ana menüye dönmek için 9'a, çıkmak için 0'a basın.");
                                string secimg = Console.ReadLine();
                                if (secimg == "9")
                                {
                                    goto anamenukartsız;
                                }
                                else if (secimg == "0")
                                {
                                    goto giris;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Hatalı kart numarası. Lütfen 12 haneli bir numara giriniz.");
                            goto secim2;
                        }
                    }
                    else if (secim2 == "2")
                    {
                        Console.WriteLine("Yatırmak istediğiniz miktarı giriniz: ");
                        int yatirilacakMiktar = Convert.ToInt32(Console.ReadLine());
                        bakiye += yatirilacakMiktar;
                        Console.WriteLine(yatirilacakMiktar + " TL hesabınıza yatırıldı. Güncel bakiye: " + bakiye + " TL");
                    }
                    else if (secim2 == "9")
                    {
                        goto anamenukartsız;
                    }
                    else if (secim2 == "0")
                    {
                        goto giris;
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz bir seçim yaptınız.");
                        goto secim2;
                    }

                    Console.WriteLine("Ana menüye dönmek için 9'a, çıkmak için 0'a basın.");
                    string secimSon = Console.ReadLine();
                    if (secimSon == "9")
                    {
                        goto anamenukartsız;
                    }
                    else if (secimSon == "0")
                    {
                        goto giris;
                    }
                }
                if (anamenusecim == "3")
                {
                secim3:
                    Console.WriteLine("Başka Hesaba EFT için 1'e, Başka Hesaba Havale için 2'ye basın. Ana menüye dönmek için 9u çıkış yapmak için 0ı tuşlayın ");
                    string secim3 = Console.ReadLine();
                    if (secim3 == "9")
                    {
                        goto anamenukartsız;
                    }
                    else if (secim3 == "0")
                    {
                        goto giris;
                    }
                    if (secim3 == "1")
                    {
                        Console.WriteLine("Lütfen EFT numarasını giriniz (başında 'tr' olmalı ve 12 haneli sayı olmalı): ");
                        string eftNumarasi = Console.ReadLine();

                        if (eftNumarasi.StartsWith("tr") && eftNumarasi.Length == 14)
                        {
                            Console.WriteLine("Yatırmak istediğiniz miktarı giriniz: ");
                            int eftMiktari = Convert.ToInt32(Console.ReadLine());

                            if (eftMiktari <= bakiye)
                            {
                                bakiye -= eftMiktari;
                                Console.WriteLine(eftMiktari + " TL başka hesaba EFT ile gönderildi. Güncel bakiye: " + bakiye + " TL");
                                Console.WriteLine("Ana menüye dönmek için 9'a, çıkmak için 0'a basın.");
                                string secimSon = Console.ReadLine();
                                if (secimSon == "9")
                                {
                                    goto anamenukartsız;
                                }
                                else if (secimSon == "0")
                                {
                                    goto giris;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Bakiye yetersiz.");
                                Console.WriteLine("Ana menüye dönmek için 9'a, çıkmak için 0'a basın.");
                                string secimSon = Console.ReadLine();
                                if (secimSon == "9")
                                {
                                    goto anamenukartsız;
                                }
                                else if (secimSon == "0")
                                {
                                    goto giris;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Hatalı EFT numarası. Lütfen tekrar deneyin.");
                            Console.WriteLine("Ana menüye dönmek için 9'a, çıkmak için 0'a basın. Yada eft nuamarasını tekrar girmek isterseniz 1'e basın");
                            string secimSon = Console.ReadLine();
                            if (secimSon == "9")
                            {
                                goto anamenukartsız;
                            }
                            else if (secimSon == "0")
                            {
                                goto giris;
                            }
                            else if (secimSon == "1") { goto secim3; }

                        }

                    }
                    else if (secim3 == "2")
                    {
                        Console.WriteLine("Lütfen havale yapmak istediğiniz hesap numarasını giriniz (11 haneli olmalı");
                        string havalenumarasi = Console.ReadLine();
                        if (havalenumarasi.Length == 11)
                        {
                            Console.WriteLine("Göndermek istediğiniz miktarı giriniz: ");
                            int havaleMiktari = Convert.ToInt32(Console.ReadLine());

                            if (havaleMiktari <= bakiye)
                            {
                                bakiye -= havaleMiktari;
                                Console.WriteLine(havaleMiktari + " TL başka hesaba havale ile gönderildi. Güncel bakiye: " + bakiye + " TL");
                                Console.WriteLine("Ana menüye dönmek için 9'a, çıkmak için 0'a basın.");
                                string secimSon = Console.ReadLine();

                                if (secimSon == "9")
                                {
                                    goto anamenukartsız;
                                }
                                else if (secimSon == "0")
                                {
                                    goto giris;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Bakiye yetersiz.");
                                Console.WriteLine("Ana menüye dönmek için 9'a, çıkmak için 0'a basın.");
                                string secimSon = Console.ReadLine();

                                if (secimSon == "9")
                                {
                                    goto anamenukartsız;
                                }
                                else if (secimSon == "0")
                                {
                                    goto giris;
                                }
                            }
                        }
                        else { Console.WriteLine("Hatalı havale numarası. Lütfen tekrar deneyin."); goto secim3; }

                    }
                }
                if (anamenusecim == "4")
                {
                    Console.WriteLine("Bu sayfa arızalı");
                    Console.WriteLine("Ana menüye dönmek için 9'a, çıkmak için 0'a basın.");
                    string secimSon = Console.ReadLine();
                    if (secimSon == "9")
                    {
                        goto anamenukartsız;
                    }
                    else if (secimSon == "0")
                    {
                        goto giris;
                    }
                }
                if (anamenusecim == "5")
                {
                secim5:
                    Console.WriteLine("Fatura ödemeleri için seçenekler:");
                    Console.WriteLine("1: Elektrik Faturası");
                    Console.WriteLine("2: Telefon Faturası");
                    Console.WriteLine("3: İnternet Faturası");
                    Console.WriteLine("4: Su Faturası");
                    Console.WriteLine("5: OGS Ödemeleri");
                    Console.WriteLine("9: Ana Menüye Dön");
                    Console.WriteLine("0: Çıkış");
                    string secim5 = Console.ReadLine();

                    if (secim5 == "9")
                    {
                        goto anamenukartsız;
                    }
                    else if (secim5 == "0")
                    {
                        goto giris;
                    }
                    else if (secim5 == "1")
                    {
                        Console.WriteLine("Elektrik faturası tutarını giriniz: ");
                        int faturaTutari = Convert.ToInt32(Console.ReadLine());

                        if (faturaTutari <= bakiye)
                        {
                            bakiye -= faturaTutari;
                            Console.WriteLine(faturaTutari + " TL elektrik faturası ödendi. Güncel bakiye: " + bakiye + " TL");
                        }
                        else
                        {
                            Console.WriteLine("Bakiye yetersiz.");
                        }

                        Console.WriteLine("Ana Menüye dönmek için 9'a, çıkmak için 0'a basın.");
                        string secimSon = Console.ReadLine();
                        if (secimSon == "9")
                        {
                            goto anamenukartsız;
                        }
                        else if (secimSon == "0")
                        {
                            goto giris;
                        }
                    }
                    else if (secim5 == "2")
                    {
                        Console.WriteLine("Telefon faturası tutarını giriniz: ");
                        int faturaTutari = Convert.ToInt32(Console.ReadLine());

                        if (faturaTutari <= bakiye)
                        {
                            bakiye -= faturaTutari;
                            Console.WriteLine(faturaTutari + " TL telefon faturası ödendi. Güncel bakiye: " + bakiye + " TL");
                        }
                        else
                        {
                            Console.WriteLine("Bakiye yetersiz.");
                        }

                        Console.WriteLine("Ana Menüye dönmek için 9'a, çıkmak için 0'a basın.");
                        string secimSon = Console.ReadLine();
                        if (secimSon == "9")
                        {
                            goto anamenukartsız;
                        }
                        else if (secimSon == "0")
                        {
                            goto giris;
                        }
                    }
                    else if (secim5 == "3")
                    {
                        Console.WriteLine("İnternet faturası tutarını giriniz: ");
                        int faturaTutari = Convert.ToInt32(Console.ReadLine());

                        if (faturaTutari <= bakiye)
                        {
                            bakiye -= faturaTutari;
                            Console.WriteLine(faturaTutari + " TL internet faturası ödendi. Güncel bakiye: " + bakiye + " TL");
                        }
                        else
                        {
                            Console.WriteLine("Bakiye yetersiz.");
                        }

                        Console.WriteLine("Ana Menüye dönmek için 9'a, çıkmak için 0'a basın.");
                        string secimSon = Console.ReadLine();
                        if (secimSon == "9")
                        {
                            goto anamenukartsız;
                        }
                        else if (secimSon == "0")
                        {
                            goto giris;
                        }
                    }
                    else if (secim5 == "4")
                    {
                        Console.WriteLine("Su faturası tutarını giriniz: ");
                        int faturaTutari = Convert.ToInt32(Console.ReadLine());

                        if (faturaTutari <= bakiye)
                        {
                            bakiye -= faturaTutari;
                            Console.WriteLine(faturaTutari + " TL su faturası ödendi. Güncel bakiye: " + bakiye + " TL");
                        }
                        else
                        {
                            Console.WriteLine("Bakiye yetersiz.");
                        }

                        Console.WriteLine("Ana Menüye dönmek için 9'a, çıkmak için 0'a basın.");
                        string secimSon = Console.ReadLine();
                        if (secimSon == "9")
                        {
                            goto anamenukartsız;
                        }
                        else if (secimSon == "0")
                        {
                            goto giris;
                        }
                    }
                    else if (secim5 == "5")
                    {
                        Console.WriteLine("OGS ödemesi tutarını giriniz: ");
                        int faturaTutari = Convert.ToInt32(Console.ReadLine());

                        if (faturaTutari <= bakiye)
                        {
                            bakiye -= faturaTutari;
                            Console.WriteLine(faturaTutari + " TL OGS ödemesi yapıldı. Güncel bakiye: " + bakiye + " TL");
                        }
                        else
                        {
                            Console.WriteLine("Bakiye yetersiz.");
                        }

                        Console.WriteLine("Ana Menüye dönmek için 9'a, çıkmak için 0'a basın.");
                        string secimSon = Console.ReadLine();
                        if (secimSon == "9")
                        {
                            goto anamenukartsız;
                        }
                        else if (secimSon == "0")
                        {
                            goto giris;
                        }
                        else
                        {
                            Console.WriteLine("Geçersiz bir seçim yaptınız.");
                            goto secim5;
                        }
                    }
                }

            }
        }
        }
    }

