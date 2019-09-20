using System.Data.Entity;
using proje1.Entities;

namespace proje1.DataAccessLayer.EntityFramework
{
    public class MyInitializer : CreateDatabaseIfNotExists<YorumlarContext>
    {
        protected override void Seed(YorumlarContext context)
        {
            Yorumlar[] yrmlr = { new Yorumlar() { yorumlar = "yorum 0 her gencin izlemesi gereken komik bi yapım :) "} };
            YorumSay[] yorumsay = { new YorumSay() { olumluSayisi = 10003, olumsuzSayisi = 18997 } };
            for (int k = 0; k < 1; k++)
            {
                context.Yorumlar.Add(yrmlr[k]);
                context.YorumSay.Add(yorumsay[k]);
            }
            context.SaveChanges();
        }
    }
}
