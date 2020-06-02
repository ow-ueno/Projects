using System;
using System.Collections.Generic;
using System.Text;

namespace AnotherNameSpace
{
    //商品クラス
    public class Product
    {

        //商品コード
        public int Code { get; private set; }
        public string Name { get; private set; }
        public int Price { get; private set; }

        //税率が複雑なご時世なので下記追加
        public bool IsReduced { get; private set; }
        private const double ReducedTax = 0.08;
        private const double Tax = 0.1;

        //コンストラクタ
        public Product(int code,string name,int price, bool isReduced){
            this.Code = code;
            this.Name = name;
            this.Price = price;
            this.IsReduced = isReduced;
        }

        //消費税額を求める
        public int GetTax()
        {

            if (IsReduced)
            {
                return (int)(Price * ReducedTax);
            }
            else
            {
                return (int)(Price * Tax);
            }

        }

        //税込価格を求める
        public int GetPriceIncludingTax()
        {

            return (int)(Price + GetTax());

        }

    }
}
