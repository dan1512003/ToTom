using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public enum Bo
{
    VĂN, SÁCH, VẠN
}

public enum So
{
    NHẤT = 1 , NHỊ = 2 , TAM =3, TỨ =4, NGŨ =5, LỤC =6, THẤT =7, BÁT=8, CỬU =9
}

public enum YeuDo
{
    THANGTHANG, ONGCU, CHICHI
}

public class LaBai
{
    public string? Ten { get; set; }
    public Bo Bo { get; set; }
    public So So { get; set; }
    public YeuDo Yeu{ get; set; }
    public bool LaYeu { get; set; }
    public int Id { get; set; }

    public override string ToString()
    {
        return LaYeu ? $"[Yêu] {Ten}" : $"{So} {Bo}";
    }
}

   

public static class ToTom
{
    public static bool SoSanhLa(LaBai LaBai1, LaBai LaBai2)
{
    if (LaBai1.LaYeu && LaBai2.LaYeu)
        return LaBai1.Yeu == LaBai2.Yeu;
    if (!LaBai1.LaYeu && !LaBai2.LaYeu)
        return LaBai1.Bo == LaBai2.Bo && LaBai1.So == LaBai2.So;
    return false;
}
    public static bool LaGiongNhau(LaBai LaBai1, LaBai LaBai2)
    {
        return SoSanhLa(LaBai1, LaBai2);
    }
public static bool LaGiongNhau(LaBai LaBai1, LaBai LaBai2,LaBai laBai3)
{
    return SoSanhLa(LaBai1, LaBai2) || SoSanhLa(LaBai1, laBai3) || SoSanhLa(LaBai2, laBai3);
}
public static List<List<LaBai>> BoLung = new List<List<LaBai>>
{
    new List<LaBai>
    {
        new LaBai { Bo = Bo.VẠN, So = So.NHẤT, LaYeu = false },
        new LaBai { Bo = Bo.SÁCH, So = So.NHẤT, LaYeu = false },
        new LaBai { Bo = Bo.VĂN, So = So.CỬU, LaYeu = false }
    },

    new List<LaBai>
    {
        new LaBai { Bo = Bo.VẠN, So = So.NHỊ, LaYeu = false },
        new LaBai { Bo = Bo.SÁCH, So = So.NHỊ, LaYeu = false },
        new LaBai { Bo = Bo.VĂN, So = So.BÁT, LaYeu = false }
    },

    new List<LaBai>
    {
        new LaBai { Bo = Bo.VẠN, So = So.TAM, LaYeu = false },
        new LaBai { Bo = Bo.SÁCH, So = So.TAM, LaYeu = false },
        new LaBai { Bo = Bo.VĂN, So = So.THẤT, LaYeu = false }
    },

    new List<LaBai>
    {
        new LaBai { Yeu = YeuDo.THANGTHANG, LaYeu = true },
        new LaBai { Yeu = YeuDo.ONGCU, LaYeu = true },
        new LaBai { Bo = Bo.SÁCH, So = So.CỬU, LaYeu = false }
    },

    new List<LaBai>
    {
        new LaBai { Bo = Bo.VẠN, So = So.CỬU, LaYeu = false },
        new LaBai { Bo = Bo.SÁCH, So = So.CỬU, LaYeu = false },
        new LaBai { Yeu = YeuDo.THANGTHANG, LaYeu = true }
    },

    new List<LaBai>
    {
        new LaBai { Bo = Bo.VẠN, So = So.CỬU, LaYeu = false },
        new LaBai { Bo = Bo.SÁCH, So = So.BÁT, LaYeu = false },
        new LaBai { Yeu = YeuDo.CHICHI, LaYeu = true }
    }
};

    public static List<LaBai> bobaiplayer = new List<LaBai>();
    public static List<LaBai> bobaial = new List<LaBai>();
    public static List<List<LaBai>> BoPhu = new List<List<LaBai>>();

    public static List<LaBai> PhuBi = new List<LaBai>();
    public static List<LaBai> PhuDoc = new List<LaBai>();
    public static List<LaBai> PhuChongCheo = new List<LaBai>();
    public static List<LaBai> LaLe = new List<LaBai>();
    public static List<LaBai> LaYeu = new List<LaBai>();
    public static List<List<LaBai>> BoPhu2 = new List<List<LaBai>>(); 
    public static int min = 0;
 public interface IPhuChecker
{
    bool IsValid(LaBai LaBai1, LaBai LaBai2);
    bool IsValid(LaBai LaBai1, LaBai LaBai2,LaBai LaBai3);
}

    public enum PhuType
    {
        PhuBi,
        PhuDoc,
        PhuChongCheo
}
//Check Phu Bí
public class PhuBiChecker : IPhuChecker
{
    public bool IsValid(LaBai LaBai1, LaBai LaBai2)
    {
        if (LaBai1.Bo != LaBai2.Bo && LaBai1.So == LaBai2.So)
        {

            return LaBai1.Bo != LaBai2.Bo && LaBai1.So == LaBai2.So;
        }
        else
        {
            return LaBai1.Bo != LaBai2.Bo && LaBai1.So == LaBai2.So;
        }
    }
    public bool IsValid(LaBai LaBai1, LaBai LaBai2, LaBai LaBai3)
    {
         if (PhuBi.Count <= 2)
        {
            if (LaBai3.So == LaBai1.So && LaBai1.Bo != LaBai3.Bo && LaBai2.Bo != LaBai3.Bo)
            {

                return LaBai3.So == LaBai1.So && LaBai1.Bo != LaBai3.Bo && LaBai2.Bo != LaBai3.Bo;
            }
            else
            {
                return LaBai3.So == LaBai1.So && LaBai1.Bo != LaBai3.Bo && LaBai2.Bo != LaBai3.Bo;
            }
        }
        else
        {
           
            foreach (var item in PhuBi)
            {
                if (item.Bo == LaBai3.Bo && item.So == LaBai3.So)
                {

                        return true;

                }
               
            }
            return false;
        }
     }
}
//Check phu dọc
    public class PhuDocChecker : IPhuChecker
    {
        public bool IsValid(LaBai LaBai1, LaBai LaBai2)
        {
            if (LaBai1.Bo == LaBai2.Bo && (LaBai2.So == LaBai1.So - 1 || LaBai2.So == LaBai1.So + 1))
            {
   if (LaBai2.So < So.NHẤT || LaBai2.So > So.CỬU)
                {
                    return false;
                }
                else
                {
                    return LaBai1.Bo == LaBai2.Bo && (LaBai2.So == LaBai1.So - 1 || LaBai2.So == LaBai1.So + 1);
         }
               
            }
            else
            {
                return LaBai1.Bo == LaBai2.Bo && (LaBai2.So == LaBai1.So - 1 || LaBai2.So == LaBai1.So + 1);
            }
        }
        public bool IsValid(LaBai LaBai1, LaBai LaBai2, LaBai LaBai3)
        {
         if (LaBai3.Bo == LaBai1.Bo && (LaBai3.So == PhuDoc[0].So - 1 || LaBai3.So == PhuDoc[PhuDoc.Count - 1].So + 1))
        {
                if (LaBai3.So < So.NHẤT || LaBai3.So > So.CỬU)
                {
                    return false;
                }
                else
                {
                    return LaBai3.Bo == LaBai1.Bo && (LaBai3.So == PhuDoc[0].So - 1 || LaBai3.So == PhuDoc[PhuDoc.Count - 1].So + 1);
         }
           
        }
        else
        {
            return LaBai3.Bo == LaBai1.Bo && (LaBai3.So == PhuDoc[0].So - 1 || LaBai3.So == PhuDoc[PhuDoc.Count - 1].So + 1);
        }
     }
}
    //Check Lưng (Phu bí đặc biệt)
    public class PhuChongCheoChecker : IPhuChecker
    {
        public bool IsValid(LaBai LaBai1, LaBai LaBai2)
        {
            foreach (var bo in BoLung)
            {

                bool contains1 = bo.Any(b => SoSanhLa(b, LaBai1));
                bool contains2 = bo.Any(b => SoSanhLa(b, LaBai2));


                if (contains1 && contains2 && !LaGiongNhau(LaBai1, LaBai2))
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsValid(LaBai LaBai1, LaBai LaBai2, LaBai LaBai3)
        {
            if (PhuChongCheo.Count <= 2)
            {
                foreach (var bo in BoLung)
                {

                    bool contains1 = bo.Any(b => SoSanhLa(b, LaBai1));
                    bool contains2 = bo.Any(b => SoSanhLa(b, LaBai2));
                    bool contains3 = bo.Any(b => SoSanhLa(b, LaBai3));

                    if (contains1 && contains2 && contains3 && !LaGiongNhau(LaBai1, LaBai2, LaBai3))
                    {
                        return true;
                    }
                }
                return false;
            }
            else
            {

                foreach (var item in PhuChongCheo)
                {
                    if (item.Bo == LaBai3.Bo && item.So == LaBai3.So || item.Yeu == LaBai3.Yeu && LaBai3.LaYeu)
                    {

                        return true;

                    }

                }
                return false;
            }

        }
    }
// Quản lý các class kiểm tra 
public static class PhuCheckerManager
{
    private static Dictionary<PhuType, IPhuChecker> _checkers = new Dictionary<PhuType, IPhuChecker>
    {
        { PhuType.PhuBi, new PhuBiChecker() },
        { PhuType.PhuDoc, new PhuDocChecker() },
        { PhuType.PhuChongCheo, new PhuChongCheoChecker() }
    };

    public static bool IsValid(PhuType type, LaBai LaBai1, LaBai LaBai2)
    {
        return _checkers[type].IsValid(LaBai1, LaBai2);
    }
 public static bool IsValid(PhuType type, LaBai LaBai1, LaBai LaBai2, LaBai laBai3)
    {
        return _checkers[type].IsValid(LaBai1, LaBai2, laBai3);
    }
    public static IEnumerable<PhuType> GetAllPhuTypes()
    {
        return _checkers.Keys;
    }
}


    public static List<LaBai> BoBai()
    {
        var cards = new List<LaBai>();
        int id = 1;

    
        foreach (Bo bo in Enum.GetValues(typeof(Bo)))
        {
            foreach (So so in Enum.GetValues(typeof(So)))
            {
                for (int i = 0; i < 4; i++) 
                {
                    cards.Add(new LaBai
                    {
                        Ten = $"{so} {bo}",
                        Bo = bo,
                        So = so,
                        LaYeu = false,
                        Id = id++
                    });
                }
            }
        }

        // Thêm các lá Yêu
        foreach (YeuDo yeudo in Enum.GetValues(typeof(YeuDo)))
        {
            for (int i = 0; i < 4; i++)
            {
                cards.Add(new LaBai
                {
                    Ten = yeudo.ToString(),
                    Yeu = yeudo,
                    LaYeu = true,
                    Id = id++
                });
            }

        }

        return cards;
    }

    public static void ChiaBoBai()
    {
        var boBai = BoBai();
        var random = new Random();

        // Shuffle
        for (int i = boBai.Count - 1; i > 0; i--)
        {
            int j = random.Next(i + 1);
            var temp = boBai[i];
            boBai[i] = boBai[j];
            boBai[j] = temp;
        }

        // Kiểm tra số lượng đủ để chia
        if (boBai.Count < 40)
        {
            Console.WriteLine("Lỗi: Bộ bài không đủ để chia.");
            return;
        }

        bobaial = boBai.GetRange(0, 20);
        bobaiplayer = boBai.GetRange(20, 20);
        var boloc = boBai.GetRange(40, boBai.Count - 40);

        Console.WriteLine("Al:");
        Console.WriteLine($"Tổng số lá: {bobaiplayer.Count}");
        foreach (var la in bobaial) Console.WriteLine(la);

        Console.WriteLine("\n Player:");
        Console.WriteLine($"Tổng số lá: {bobaiplayer.Count}");
        foreach (var la in bobaiplayer) Console.WriteLine(la);

        Console.WriteLine($"\n Bộ lọc (nọc): {boloc.Count} lá");
    }

    public static void ChonPhuTotNhat()
    {
        BoPhu.Clear();
        for (int i = 0; i < bobaiplayer.Count - 1; i++)
        {
            for (int j = i + 1; j < bobaiplayer.Count; j++)
            {
              
                foreach (var type in PhuCheckerManager.GetAllPhuTypes())
                {
                    if (PhuCheckerManager.IsValid(type, bobaiplayer[i], bobaiplayer[j]))
                    {


                        switch (type)
                        {
                            case PhuType.PhuBi:
                                {
                                    PhuBi.Clear();
                                    PhuBi.Add(bobaiplayer[i]);
                                    PhuBi.Add(bobaiplayer[j]);

                                    for (int l = j + 1; l < bobaiplayer.Count; l++)
                                    {

                                        if (PhuCheckerManager.IsValid(type, bobaiplayer[i], bobaiplayer[j], bobaiplayer[l]))
                                        {
                                            PhuBi.Add(bobaiplayer[l]);
                                       
                                            BoPhu.Add(new List<LaBai>(PhuBi));
                                        }
                                       

                                    }
                                    break;
                                }

                            case PhuType.PhuDoc:
                                {
                                    PhuDoc.Clear();
                                    PhuDoc.Add(bobaiplayer[i]);
                                    PhuDoc.Add(bobaiplayer[j]);
                                    PhuDoc = PhuDoc.OrderBy(card => card.So).ToList();

                                      for (int l = j + 1; l < bobaiplayer.Count; l++)
                                    {

                                        if (PhuCheckerManager.IsValid(type, bobaiplayer[i], bobaiplayer[j], bobaiplayer[l]))
                                        {
                                        PhuDoc.Add(bobaiplayer[l]);
                                        PhuDoc = PhuDoc.OrderBy(card => card.So).ToList();
                                     
                                        BoPhu.Add(new List<LaBai>(PhuDoc));
                                        }

                                    }
                                    break;

                                }
                            case PhuType.PhuChongCheo:
                                {
                                    PhuChongCheo.Clear();
                                    PhuChongCheo.Add(bobaiplayer[i]);
                                    PhuChongCheo.Add(bobaiplayer[j]);
                                      for (int l = j + 1; l < bobaiplayer.Count; l++)
                                    {

                                        if (PhuCheckerManager.IsValid(type, bobaiplayer[i], bobaiplayer[j], bobaiplayer[l]))
                                        {
                                        PhuChongCheo.Add(bobaiplayer[l]);
                                     
                                        BoPhu.Add(new List<LaBai>(PhuChongCheo));
                                        }

                                    }
                                    break;
                                }
                        }
                    }
                }
               
            }



        }



        foreach (List<LaBai> phu1 in BoPhu)
        {
            var boPhuTam = new List<List<LaBai>>();
            boPhuTam.Add(phu1);


            foreach (List<LaBai> phu2 in BoPhu)
            {
                if (phu1 == phu2) continue;

                bool trung = false;
                foreach (var p1 in boPhuTam)
                {
                    foreach (var la1 in p1)
                    {
                        foreach (var la2 in phu2)
                        {
                            if (la1.Id == la2.Id)
                            {
                                trung = true;
                                break;
                            }
                        }
                        if (trung) break;
                    }
                    if (trung) break;
                }

                if (!trung)
                {
                    boPhuTam.Add(phu2);
                }
            }
            if (min == 0)
            {
                int count = 0;

                foreach (var phu in boPhuTam)
                    count += phu.Count;
                int soLaLe = bobaiplayer.Count - count;
                BoPhu2 = new List<List<LaBai>>(boPhuTam);
                min = soLaLe;
            }

            else
            {
                int count = 0;
                foreach (var phu in boPhuTam)
                    count += phu.Count;

                int soLaLe = bobaiplayer.Count - count;
                if (soLaLe < min)
                {
                    BoPhu2 = new List<List<LaBai>>(boPhuTam);
                    min = soLaLe;
                }
            }


        }
Console.WriteLine("Các bộ Phu tốt nhất (ít bài lẻ nhất):");
foreach (var phu in BoPhu2)
{
    Console.WriteLine("Bộ Phu:");
    foreach (var la in phu)
    {
        Console.WriteLine($"  - {la}"); 
    
    }
}

    }
}
class Program
{
    static void Main()
    {
        ToTom.ChiaBoBai();
        ToTom.ChonPhuTotNhat();
    }
}
