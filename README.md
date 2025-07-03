120 lá bài
 chất (3)  : vạn , sách , văn  số 1 - > 9
 yêu đỏ :chi chi , thang thang , ông cụ
 yêu đen: nhất sách , nhất văn , nhất vạn
mỗi người chơi:20 lá

Các loại phu và lưng
Phu yêu : nhất vạn, nhất sách , nhất văn ,chi chi(2 or 1), ông cụ( 2 hoặc 1), thang thang(2 hoặc 1)
Phu dọc:  3 lá trở lên cùng  từ 1-> 9
Phu bí : 3 lá bài khác chất cùng số 
Lưng : phu bí đặc biệt
-Nhất vạn Nhất sách cửu văn
-Nhị van Nhị sách bát văn
-Tam vạn Tam sách thất văn(tôm)
-Thang thang ông cụ cửu sách
-Cửu vạn cửu sách thang thang
-Cửu vạn bát sách chi  chi (lèo)
-Nhất nhị tam văn
- ba quân giống nhau (có sẵn ( úp khàn or bất thưc) từ khác phỗng) 
- 4 quân giống nhau (có sẵn ( úp thiên khai  or bất thưc))
bất thực  khàn :
-bất thực ăn cả: nếu xếp vào 2 phu
-bất thưc ăn 2 đánh 1: ăn 2 phu đánh đi 1
- bất thực yêu hoàn yêu
-bất thực bí hoàn bí

XẾP BÀI 
- mảng danh sách chứa bộ phu (chứa tất cả các phu trong bộ bài)-> từ đó chọn bộ phu tốt nhất (ít bài lẻ)
- mảng danh sách chứa bài lẻ (ko có phu) -> xếp những lá có thể thành phu ít bài lẻ
BẤT THỰC:
-Kiểm tra xem bộ bài có 4 or 3 lá giống nhau không sau đó so sánh với bộ phụ tốt nhất tìm đc có phu nào 3 lá giống nhau không nếu
thì bất thực 

kiểm tra từng lá  bài một  xem  :

+ kiểm tra bí : nếu khác các lài cùng chất hoặc khác chất khác số thì retrun ngược lại thì kiểm tra  xem có  3 hàng cùng bí khôn nếu không thì return ngược lại thì đưa vào phu
+ kiểm tra dọc : nếu khác chất return  ngược lại thì kiểm tra có liên thông khay không sau đó nếu không retrun ngược lại đưa vào mảng chúa phuwww
+ kiểm tra yêu : kiêm tra có  ghép được với với các lá bài khác không nếu không thì đưa vào mảng chứa yêu lẻ  ngược lại đưa vào phu  

 
sau đó lại kiểm tra các phu đó xem phu nào  có  số bài lẻ nhỏ nhất thì chọn bằng cách so sánh các phần tử phu với nhau xem 
có phần tử nào trong hai phu trùng nhau không  nếu không cộng là bài đó  trừ đi tổng lá bài

 static bool IsPhuDoc(LaBai LaBai1, LaBai LaBai2)
    {
        if (LaBai1.Bo == LaBai2.Bo && (LaBai2.So == LaBai1.So - 1 || LaBai2.So == LaBai1.So + 1))
        {

            return LaBai1.Bo == LaBai2.Bo && (LaBai2.So == LaBai1.So - 1 || LaBai2.So == LaBai1.So + 1);
        }
        else
        {
            return LaBai1.Bo == LaBai2.Bo && (LaBai2.So == LaBai1.So - 1 || LaBai2.So == LaBai1.So + 1);
        }

    }
    static bool IsPhuChongCheo(LaBai LaBai1, LaBai LaBai2)
    {
        if (LaBai1.Bo == Bo.VẠN && LaBai1.So == So.NHẤT ||
            LaBai1.Bo == Bo.SÁCH && LaBai1.So == So.NHẤT ||
            LaBai1.Bo == Bo.VĂN && LaBai1.So == So.CỬU ||
            LaBai1.Bo == Bo.VẠN && LaBai1.So == So.NHỊ ||
            LaBai1.Bo == Bo.SÁCH && LaBai1.So == So.NHỊ ||
            LaBai1.Bo == Bo.VĂN && LaBai1.So == So.BÁT ||
            LaBai1.Bo == Bo.VẠN && LaBai1.So == So.TAM ||
            LaBai1.Bo == Bo.SÁCH && LaBai1.So == So.TAM ||
            LaBai1.Bo == Bo.VĂN && LaBai1.So == So.THẤT
         )
        {
            if (LaBai1.Bo == Bo.VẠN && LaBai1.So == So.NHẤT)
            {
                if (LaBai2.Bo == Bo.SÁCH && LaBai2.So == So.NHẤT ||
                    LaBai2.Bo == Bo.VĂN && LaBai2.So == So.CỬU)
                {

                    return LaBai2.Bo == Bo.SÁCH && LaBai2.So == So.NHẤT ||
                    LaBai2.Bo == Bo.VĂN && LaBai2.So == So.CỬU;
                }
                else
                {
                    return LaBai2.Bo == Bo.SÁCH && LaBai2.So == So.NHẤT ||
                      LaBai2.Bo == Bo.VĂN && LaBai2.So == So.CỬU;
                }

            }
            else if (LaBai1.Bo == Bo.SÁCH && LaBai1.So == So.NHẤT)
            {
                if (LaBai2.Bo == Bo.VẠN && LaBai2.So == So.NHẤT ||
                    LaBai2.Bo == Bo.VĂN && LaBai2.So == So.CỬU)
                {

                    return LaBai2.Bo == Bo.VẠN && LaBai2.So == So.NHẤT ||
                    LaBai2.Bo == Bo.VĂN && LaBai2.So == So.CỬU;
                }
                else
                {
                    return LaBai2.Bo == Bo.VẠN && LaBai2.So == So.NHẤT ||
                     LaBai2.Bo == Bo.VĂN && LaBai2.So == So.CỬU;
                }

            }
            else if (LaBai1.Bo == Bo.VĂN && LaBai1.So == So.CỬU)
            {
                if (LaBai2.Bo == Bo.VẠN && LaBai2.So == So.NHẤT ||
                    LaBai2.Bo == Bo.SÁCH && LaBai2.So == So.NHẤT)
                {

                    return LaBai2.Bo == Bo.VẠN && LaBai2.So == So.NHẤT ||
                    LaBai2.Bo == Bo.SÁCH && LaBai2.So == So.NHẤT;
                }
                else
                {
                    return LaBai2.Bo == Bo.VẠN && LaBai2.So == So.NHẤT ||
                    LaBai2.Bo == Bo.SÁCH && LaBai2.So == So.NHẤT;
                }


            }
            else if (LaBai1.Bo == Bo.VẠN && LaBai1.So == So.NHỊ)
            {
                if (LaBai2.Bo == Bo.SÁCH && LaBai2.So == So.NHỊ ||
                    LaBai2.Bo == Bo.VĂN && LaBai2.So == So.BÁT)
                {

                    return LaBai2.Bo == Bo.SÁCH && LaBai2.So == So.NHỊ ||
                    LaBai2.Bo == Bo.VĂN && LaBai2.So == So.BÁT;
                }
                else
                {
                    return LaBai2.Bo == Bo.SÁCH && LaBai2.So == So.NHỊ ||
                     LaBai2.Bo == Bo.VĂN && LaBai2.So == So.BÁT;
                }

            }
            else if (LaBai1.Bo == Bo.SÁCH && LaBai1.So == So.NHỊ)
            {
                if (LaBai2.Bo == Bo.VẠN && LaBai2.So == So.NHỊ ||
                    LaBai2.Bo == Bo.VĂN && LaBai2.So == So.BÁT)
                {

                    return LaBai2.Bo == Bo.VẠN && LaBai2.So == So.NHỊ ||
                    LaBai2.Bo == Bo.VĂN && LaBai2.So == So.BÁT;
                }
                else
                {
                    return LaBai2.Bo == Bo.VẠN && LaBai2.So == So.NHỊ ||
                   LaBai2.Bo == Bo.VĂN && LaBai2.So == So.BÁT;
                }

            }
            else if (LaBai1.Bo == Bo.VĂN && LaBai1.So == So.BÁT)
            {
                if (LaBai2.Bo == Bo.VẠN && LaBai2.So == So.NHỊ ||
                     LaBai2.Bo == Bo.SÁCH && LaBai2.So == So.NHỊ)
                {

                    return LaBai2.Bo == Bo.VẠN && LaBai2.So == So.NHỊ ||
                           LaBai2.Bo == Bo.SÁCH && LaBai2.So == So.NHỊ;
                }
                else
                {
                    return LaBai2.Bo == Bo.VẠN && LaBai2.So == So.NHỊ ||
                            LaBai2.Bo == Bo.SÁCH && LaBai2.So == So.NHỊ;
                }

            }
            else if (LaBai1.Bo == Bo.VẠN && LaBai2.So == So.TAM)
            {
                if (LaBai2.Bo == Bo.SÁCH && LaBai2.So == So.TAM ||
                    LaBai2.Bo == Bo.VĂN && LaBai2.So == So.THẤT)
                {

                    return LaBai2.Bo == Bo.SÁCH && LaBai2.So == So.TAM ||
                    LaBai2.Bo == Bo.VĂN && LaBai2.So == So.THẤT;
                }
                else
                {
                    return LaBai2.Bo == Bo.SÁCH && LaBai2.So == So.TAM ||
                    LaBai2.Bo == Bo.VĂN && LaBai2.So == So.THẤT;
                }

            }
            else if (LaBai1.Bo == Bo.SÁCH && LaBai1.So == So.TAM)
            {
                if (LaBai2.Bo == Bo.VẠN && LaBai2.So == So.TAM ||
                    LaBai2.Bo == Bo.VĂN && LaBai2.So == So.THẤT)
                {

                    return LaBai2.Bo == Bo.VẠN && LaBai2.So == So.TAM ||
                    LaBai2.Bo == Bo.VĂN && LaBai2.So == So.THẤT;
                }
                else
                {
                    return LaBai2.Bo == Bo.VẠN && LaBai2.So == So.TAM ||
                    LaBai2.Bo == Bo.VĂN && LaBai2.So == So.THẤT;
                }

            }
            else if (LaBai1.Bo == Bo.VĂN && LaBai1.So == So.THẤT)
            {
                if (LaBai2.Bo == Bo.VẠN && LaBai2.So == So.TAM ||
                    LaBai2.Bo == Bo.SÁCH && LaBai2.So == So.TAM)
                {

                    return LaBai2.Bo == Bo.VẠN && LaBai2.So == So.TAM ||
                    LaBai2.Bo == Bo.SÁCH && LaBai2.So == So.TAM;
                }
                else
                {
                    return LaBai2.Bo == Bo.VẠN && LaBai2.So == So.TAM ||
                    LaBai2.Bo == Bo.SÁCH && LaBai2.So == So.TAM;
                }


            }

            return false;

        }
        else
        {
            return LaBai1.Bo == Bo.VẠN && LaBai1.So == So.NHẤT ||
                                   LaBai1.Bo == Bo.SÁCH && LaBai1.So == So.NHẤT ||
                                   LaBai1.Bo == Bo.VĂN && LaBai1.So == So.CỬU ||
                                   LaBai1.Bo == Bo.VẠN && LaBai1.So == So.NHỊ ||
                                   LaBai1.Bo == Bo.SÁCH && LaBai1.So == So.NHỊ ||
                                   LaBai1.Bo == Bo.VĂN && LaBai1.So == So.BÁT ||
                                   LaBai1.Bo == Bo.VẠN && LaBai1.So == So.TAM ||
                                   LaBai1.Bo == Bo.SÁCH && LaBai1.So == So.TAM ||
                                   LaBai1.Bo == Bo.VĂN && LaBai1.So == So.THẤT;
        }

    }
    static bool IsPhuBi(LaBai LaBai1, LaBai LaBai2)
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
    static bool IsYeu(LaBai LaBai1, LaBai LaBai2)
    {
        if (LaBai1.LaYeu)
        {
            if (LaBai1.Yeu == YeuDo.ONGCU)
            {
                if (LaBai1.Yeu == YeuDo.THANGTHANG || LaBai2.So == So.CỬU && LaBai2.Bo == Bo.SÁCH)
                {

                    return LaBai1.Yeu == YeuDo.THANGTHANG || LaBai2.So == So.CỬU && LaBai2.Bo == Bo.SÁCH;
                }
                else
                {
                    return LaBai1.Yeu == YeuDo.THANGTHANG || LaBai2.So == So.CỬU && LaBai2.Bo == Bo.SÁCH;
                }


            }
            else if (LaBai1.Yeu == YeuDo.CHICHI)
            {
                if (LaBai2.So == So.BÁT && LaBai2.Bo == Bo.SÁCH || LaBai2.So == So.CỬU && LaBai2.Bo == Bo.VẠN)
                {

                    return LaBai2.So == So.BÁT && LaBai2.Bo == Bo.SÁCH || LaBai2.So == So.CỬU && LaBai2.Bo == Bo.VẠN;
                }
                else
                {
                    return LaBai2.So == So.BÁT && LaBai2.Bo == Bo.SÁCH || LaBai2.So == So.CỬU && LaBai2.Bo == Bo.VẠN;
                }

            }
            else if (LaBai1.Yeu == YeuDo.THANGTHANG)
            {
                if (LaBai2.So == So.CỬU && LaBai2.Bo == Bo.SÁCH || LaBai2.So == So.CỬU && LaBai2.Bo == Bo.VẠN || LaBai2.Yeu == YeuDo.ONGCU)
                {

                    return LaBai2.So == So.CỬU && LaBai2.Bo == Bo.SÁCH || LaBai2.So == So.CỬU && LaBai2.Bo == Bo.VẠN || LaBai2.Yeu == YeuDo.ONGCU;
                }
                else
                {
                    return LaBai2.So == So.CỬU && LaBai2.Bo == Bo.SÁCH || LaBai2.So == So.CỬU && LaBai2.Bo == Bo.VẠN || LaBai2.Yeu == YeuDo.ONGCU;
                }

            }
            return false;

        }
        else
        {
            return LaBai1.LaYeu;
        }

    }

    static bool IsPhuDoc(LaBai LaBai1, LaBai LaBai2, LaBai LaBai3)
    {
        if (LaBai3.Bo == LaBai1.Bo && (LaBai3.So == PhuDoc[0].So - 1 || LaBai3.So == PhuDoc[PhuDoc.Count - 1].So + 1))
        {

            return LaBai3.Bo == LaBai1.Bo && (LaBai3.So == PhuDoc[0].So - 1 || LaBai3.So == PhuDoc[PhuDoc.Count - 1].So + 1);
        }
        else
        {
            return LaBai3.Bo == LaBai1.Bo && (LaBai3.So == PhuDoc[0].So - 1 || LaBai3.So == PhuDoc[PhuDoc.Count - 1].So + 1);
        }
    }
    static bool IsPhuBi(LaBai LaBai1, LaBai LaBai2, LaBai LaBai3)
    {
        if (Phu.Count <= 2)
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
            bool check = false;
            foreach (var item in Phu)
            {
                if (item.Bo == LaBai3.Bo && item.So == LaBai3.So)
                {

                    check = true;
                    break;

                }
                else
                {
                    continue;
                }
            }
            return check;
        }
    }
    static bool IsYeu(LaBai LaBai1, LaBai LaBai2, LaBai LaBai3)
    {
        if (Phu.Count <= 2)
        {
            if (LaBai1.Yeu == YeuDo.ONGCU && LaBai2.So == So.CỬU && LaBai2.Bo == Bo.SÁCH
            || LaBai1.Yeu == YeuDo.ONGCU && LaBai2.Yeu == YeuDo.THANGTHANG
            || LaBai2.Yeu == YeuDo.ONGCU && LaBai1.So == So.CỬU && LaBai1.Bo == Bo.SÁCH
            || LaBai2.Yeu == YeuDo.ONGCU && LaBai1.Yeu == YeuDo.THANGTHANG
            )
            {
                if (LaBai2.Yeu == YeuDo.THANGTHANG && LaBai3.So == So.CỬU && LaBai3.Bo == Bo.SÁCH
                || LaBai1.Yeu == YeuDo.THANGTHANG && LaBai3.So == So.CỬU && LaBai3.Bo == Bo.SÁCH
                )
                {


                    return LaBai2.Yeu == YeuDo.THANGTHANG && LaBai3.So == So.CỬU && LaBai3.Bo == Bo.SÁCH
                || LaBai1.Yeu == YeuDo.THANGTHANG && LaBai3.So == So.CỬU && LaBai3.Bo == Bo.SÁCH;

                }
                else if (LaBai2.So == So.CỬU && LaBai2.Bo == Bo.SÁCH && LaBai3.Yeu == YeuDo.THANGTHANG
                || LaBai1.So == So.CỬU && LaBai1.Bo == Bo.SÁCH && LaBai3.Yeu == YeuDo.THANGTHANG
                )
                {

                    return LaBai2.So == So.CỬU && LaBai2.Bo == Bo.SÁCH && LaBai3.Yeu == YeuDo.THANGTHANG
                || LaBai1.So == So.CỬU && LaBai1.Bo == Bo.SÁCH && LaBai3.Yeu == YeuDo.THANGTHANG;
                }
                else
                {
                    return false;
                }

            }
            else if (LaBai1.Yeu == YeuDo.CHICHI && LaBai2.So == So.BÁT && LaBai2.Bo == Bo.SÁCH
            || LaBai1.Yeu == YeuDo.CHICHI && LaBai2.So == So.CỬU && LaBai2.Bo == Bo.VẠN
            || LaBai2.Yeu == YeuDo.CHICHI && LaBai1.So == So.BÁT && LaBai1.Bo == Bo.SÁCH
            || LaBai2.Yeu == YeuDo.CHICHI && LaBai1.So == So.CỬU && LaBai1.Bo == Bo.VẠN

            )
            {
                if (LaBai2.So == So.CỬU && LaBai2.Bo == Bo.VẠN && LaBai3.So == So.BÁT && LaBai3.Bo == Bo.SÁCH
                || LaBai1.So == So.CỬU && LaBai1.Bo == Bo.VẠN && LaBai3.So == So.BÁT && LaBai3.Bo == Bo.SÁCH

                )
                {

                    return LaBai2.So == So.CỬU && LaBai2.Bo == Bo.VẠN && LaBai3.So == So.BÁT && LaBai3.Bo == Bo.SÁCH
                || LaBai1.So == So.CỬU && LaBai1.Bo == Bo.VẠN && LaBai3.So == So.BÁT && LaBai3.Bo == Bo.SÁCH;

                }
                else if (LaBai2.So == So.BÁT && LaBai2.Bo == Bo.SÁCH && LaBai3.So == So.CỬU && LaBai3.Bo == Bo.VẠN
                || LaBai1.So == So.BÁT && LaBai1.Bo == Bo.SÁCH && LaBai3.So == So.CỬU && LaBai3.Bo == Bo.VẠN
                )
                {

                    return LaBai2.So == So.BÁT && LaBai2.Bo == Bo.SÁCH && LaBai3.So == So.CỬU && LaBai3.Bo == Bo.VẠN
                || LaBai1.So == So.BÁT && LaBai1.Bo == Bo.SÁCH && LaBai3.So == So.CỬU && LaBai3.Bo == Bo.VẠN;
                }
                else
                {
                    return false;
                }


            }
            else if (LaBai1.Yeu == YeuDo.THANGTHANG && LaBai2.So == So.CỬU && LaBai2.Bo == Bo.SÁCH
            || LaBai1.Yeu == YeuDo.THANGTHANG && LaBai2.So == So.CỬU && LaBai2.Bo == Bo.VẠN
            || LaBai1.Yeu == YeuDo.THANGTHANG && LaBai2.Yeu == YeuDo.ONGCU
            || LaBai2.Yeu == YeuDo.THANGTHANG && LaBai1.So == So.CỬU && LaBai1.Bo == Bo.SÁCH
            || LaBai2.Yeu == YeuDo.THANGTHANG && LaBai1.So == So.CỬU && LaBai1.Bo == Bo.VẠN
            || LaBai2.Yeu == YeuDo.THANGTHANG && LaBai1.Yeu == YeuDo.ONGCU
            )
            {
                if (LaBai2.So == So.CỬU && LaBai2.Bo == Bo.VẠN && LaBai3.So == So.CỬU && LaBai3.Bo == Bo.SÁCH
                || LaBai1.So == So.CỬU && LaBai1.Bo == Bo.VẠN && LaBai3.So == So.CỬU && LaBai3.Bo == Bo.SÁCH
                )
                {

                    return LaBai2.So == So.CỬU && LaBai2.Bo == Bo.VẠN && LaBai3.So == So.CỬU && LaBai3.Bo == Bo.SÁCH
                || LaBai1.So == So.CỬU && LaBai1.Bo == Bo.VẠN && LaBai3.So == So.CỬU && LaBai3.Bo == Bo.SÁCH;
                }
                else if (LaBai2.So == So.CỬU && LaBai2.Bo == Bo.SÁCH && LaBai3.So == So.CỬU && LaBai3.Bo == Bo.VẠN
                || LaBai1.So == So.CỬU && LaBai1.Bo == Bo.SÁCH && LaBai3.So == So.CỬU && LaBai3.Bo == Bo.VẠN
                )
                {

                    return LaBai2.So == So.CỬU && LaBai2.Bo == Bo.SÁCH && LaBai3.So == So.CỬU && LaBai3.Bo == Bo.VẠN
                || LaBai1.So == So.CỬU && LaBai1.Bo == Bo.SÁCH && LaBai3.So == So.CỬU && LaBai3.Bo == Bo.VẠN;
                }
                else if (LaBai2.Yeu == YeuDo.ONGCU && LaBai3.So == So.CỬU && LaBai3.Bo == Bo.SÁCH
                || LaBai1.Yeu == YeuDo.ONGCU && LaBai3.So == So.CỬU && LaBai3.Bo == Bo.SÁCH
                )
                {

                    return LaBai2.Yeu == YeuDo.ONGCU && LaBai3.So == So.CỬU && LaBai3.Bo == Bo.SÁCH
                || LaBai1.Yeu == YeuDo.ONGCU && LaBai3.So == So.CỬU && LaBai3.Bo == Bo.SÁCH;
                }
                else
                {
                    return false;
                }

            }
            return false;
        }
        else
        {
            bool check = false;
            foreach (var item in PhuYeu)
            {
                if (item.Bo == LaBai3.Bo && item.So == LaBai3.So || item.Yeu == LaBai3.Yeu)
                {

                    check = true;
                    break;
                }
                else
                {
                    check = false;
                    continue;
                }
            }
            return check;
        }
    }
    static bool IsPhuChongCheo(LaBai LaBai1, LaBai LaBai2, LaBai LaBai3)
    {
        if (Phu.Count <= 2)
        {

            if (LaBai1.So == So.NHẤT && LaBai1.Bo == Bo.VẠN && LaBai2.So == So.NHẤT && LaBai2.Bo == Bo.SÁCH ||
               LaBai2.So == So.NHẤT && LaBai2.Bo == Bo.VẠN && LaBai1.So == So.NHẤT && LaBai1.Bo == Bo.SÁCH
             )
            {
                if (LaBai3.Bo == Bo.VĂN && LaBai3.So == So.CỬU)
                {

                    return LaBai3.Bo == Bo.VĂN && LaBai3.So == So.CỬU;
                }
                else
                {
                    return LaBai3.Bo == Bo.VĂN && LaBai3.So == So.CỬU;
                }
            }
            else if (LaBai1.So == So.CỬU && LaBai1.Bo == Bo.VĂN && LaBai2.So == So.NHẤT && LaBai2.Bo == Bo.SÁCH ||
               LaBai2.So == So.CỬU && LaBai2.Bo == Bo.VĂN && LaBai1.So == So.NHẤT && LaBai1.Bo == Bo.SÁCH)
            {
                if (LaBai3.Bo == Bo.VẠN && LaBai3.So == So.NHẤT)
                {

                    return LaBai3.Bo == Bo.VẠN && LaBai3.So == So.NHẤT;
                }
                else
                {
                    return LaBai3.Bo == Bo.VẠN && LaBai3.So == So.NHẤT;
                }
            }
            else if (LaBai1.So == So.CỬU && LaBai1.Bo == Bo.VĂN && LaBai2.So == So.NHẤT && LaBai2.Bo == Bo.VẠN ||
               LaBai2.So == So.CỬU && LaBai2.Bo == Bo.VĂN && LaBai1.So == So.NHẤT && LaBai1.Bo == Bo.VẠN)
            {
                if (LaBai3.Bo == Bo.SÁCH && LaBai3.So == So.NHẤT)
                {

                    return LaBai3.Bo == Bo.SÁCH && LaBai3.So == So.NHẤT;
                }
                else
                {
                    return LaBai3.Bo == Bo.SÁCH && LaBai3.So == So.NHẤT;
                }
            }
            else if (LaBai1.So == So.NHỊ && LaBai1.Bo == Bo.VẠN && LaBai2.So == So.NHỊ && LaBai2.Bo == Bo.SÁCH ||
               LaBai2.So == So.NHỊ && LaBai2.Bo == Bo.VẠN && LaBai1.So == So.NHỊ && LaBai1.Bo == Bo.SÁCH
              )
            {
                if (LaBai3.Bo == Bo.VĂN && LaBai3.So == So.BÁT)
                {

                    return LaBai3.Bo == Bo.VĂN && LaBai3.So == So.BÁT;
                }
                else
                {
                    return LaBai3.Bo == Bo.VĂN && LaBai3.So == So.BÁT;
                }
            }
            else if (LaBai1.So == So.BÁT && LaBai1.Bo == Bo.VĂN && LaBai2.So == So.NHỊ && LaBai2.Bo == Bo.SÁCH ||
               LaBai2.So == So.BÁT && LaBai2.Bo == Bo.VĂN && LaBai1.So == So.NHỊ && LaBai1.Bo == Bo.SÁCH)
            {
                if (LaBai3.Bo == Bo.VẠN && LaBai3.So == So.NHỊ)
                {

                    return LaBai3.Bo == Bo.VẠN && LaBai3.So == So.NHỊ;
                }
                else
                {
                    return LaBai3.Bo == Bo.VẠN && LaBai3.So == So.NHỊ;
                }
            }
            else if (LaBai1.So == So.BÁT && LaBai1.Bo == Bo.VĂN && LaBai2.So == So.NHỊ && LaBai2.Bo == Bo.VẠN ||
               LaBai2.So == So.BÁT && LaBai2.Bo == Bo.VĂN && LaBai1.So == So.NHỊ && LaBai1.Bo == Bo.VẠN)
            {
                if (LaBai3.Bo == Bo.SÁCH && LaBai3.So == So.NHỊ)
                {

                    return LaBai3.Bo == Bo.SÁCH && LaBai3.So == So.NHỊ;
                }
                else
                {
                    return LaBai3.Bo == Bo.SÁCH && LaBai3.So == So.NHỊ;
                }
            }
            else if (LaBai1.So == So.TAM && LaBai1.Bo == Bo.VẠN && LaBai2.So == So.TAM && LaBai2.Bo == Bo.SÁCH ||
               LaBai2.So == So.TAM && LaBai2.Bo == Bo.VẠN && LaBai1.So == So.TAM && LaBai1.Bo == Bo.SÁCH
             )
            {
                if (LaBai3.Bo == Bo.VĂN && LaBai3.So == So.THẤT)
                {

                    return LaBai3.Bo == Bo.VĂN && LaBai3.So == So.THẤT;
                }
                else
                {
                    return LaBai3.Bo == Bo.VĂN && LaBai3.So == So.THẤT;
                }
            }
            else if (LaBai1.So == So.THẤT && LaBai1.Bo == Bo.VĂN && LaBai2.So == So.TAM && LaBai2.Bo == Bo.SÁCH ||
               LaBai2.So == So.THẤT && LaBai2.Bo == Bo.VĂN && LaBai1.So == So.TAM && LaBai1.Bo == Bo.SÁCH)
            {
                if (LaBai3.Bo == Bo.VẠN && LaBai3.So == So.TAM)
                {

                    return LaBai3.Bo == Bo.VẠN && LaBai3.So == So.TAM;
                }
                else
                {
                    return LaBai3.Bo == Bo.VẠN && LaBai3.So == So.TAM;
                }
            }
            else if (LaBai1.So == So.THẤT && LaBai1.Bo == Bo.VĂN && LaBai2.So == So.TAM && LaBai2.Bo == Bo.VẠN ||
               LaBai2.So == So.THẤT && LaBai2.Bo == Bo.VĂN && LaBai1.So == So.TAM && LaBai1.Bo == Bo.VẠN)
            {
                if (LaBai3.Bo == Bo.SÁCH && LaBai3.So == So.TAM)
                {

                    return LaBai3.Bo == Bo.SÁCH && LaBai3.So == So.TAM;
                }
                else
                {
                    return LaBai3.Bo == Bo.SÁCH && LaBai3.So == So.TAM;
                }
            }
            return false;
        }
        else
        {
            bool check = false;
            foreach (var item in Phu)
            {
                if (item.Bo == LaBai3.Bo && item.So == LaBai3.So)
                {

                    check = true;
                    break;

                }
                else
                {
                    continue;
                }
            }
            return check;
        }
    }

public static List<List<LaBai>> BoPhu1 = new List<List<LaBai>>;
public static List<List<LaBai>> BoPhu2 = new List<List<LaBai>>;
public List<List<LaBai>> BoPhu = new List<List<LaBai>>;
int soluong=20;
int max =0;
foreach ( List<LaBai> Phu1 in BoPhu){
BoPhu1.Clear()
     BoPhu1.Add(Phu1)
foreach ( List<LaBai> Phu2 in BoPhu){
     bool check =false ;
     foreach ( List<LaBai> Phu3 in BoPhu1){
     foreach( var LaBai LaBaiPhu1 in Phu3){

     
     foreach( var LaBai LaBaiPhu2 in Phu2){

       if( LaBaiPhu1.Id == LaBaiPhu2.Id ){
        check = true;
        break;
       }

     }
if(check){
    break;
}
}
   if(check){
    break;
}  }
  if(!check) {
    Phu.Add(BoPhu2)
  } 
      
     }
 if(BoPhu2 ==null){

  int temp ;
     int count;
foreach ( List<LaBai> Phu4 in BoPhu1){
 foreach( var LaBai LaBaiPhu3 in Phu4){
count++;
 }

}
max = soluong - count

 BoPhu2=BoPhu1;

 }else{
        int temp ;
     int count;
foreach ( List<LaBai> Phu4 in BoPhu1){
 foreach( var LaBai LaBaiPhu3 in Phu4){
count++;
 }

}
temp = soluong - count
if(temp > max){
    BoPhu2=BoPhu1;
    max= temp;
}
 }

}


public static List<List<LaBai>> BoPhu2 = new(); 
int max = 0;
int soluong = 20; 


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

    // Đếm số lá của tổ hợp hiện tại
    int count = 0;
    foreach (var phu in boPhuTam)
        count += phu.Count;

    int soLaLe = soluong - count;
    if (soLaLe < soluong - max) // ít bài lẻ hơn → tốt hơn
    {
        BoPhu2 = new List<List<LaBai>>(boPhuTam);
        max = count;
    }
}
