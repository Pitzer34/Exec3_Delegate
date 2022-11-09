using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //在主控台應用程式裡,宣告一個 static method, 名稱為GetEvenItems
    //傳回型別是 List<int>
    //傳入參數有二個
    //1.List<int> 是待篩選的集合, 內含多個奇/偶數的數值
    //2.Func<int ,bool> 用來篩選, 是偶數傳回true, 奇數傳回false
    //在 Main 裡叫用 GetEvenItems, 傳入一個集合, 並傳回一個只包含偶數的集合

    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> example = new List<int>() { 1,2,3,4,5,6,7,8,9,10};
            Func<int, bool> isEven = x => x % 2 == 0;
            List<int> Ans = GetEvenItems(example, isEven);
            

        }
        static List<int> GetEvenItems(List<int> intItem, Func<int, bool> funcItem)
        {
            var result = new List<int>();

            foreach (int example01 in intItem)
            {
                if (funcItem(example01) == true)
                {
                    result.Add(example01);
                }
            }
            return result;
        }
    }
}
