using System;
using System.Linq;
using VMRepresentacao.Domain.Entities;
using VMRepresentacao.Domain.ValueObjects;
using VMRepresentacao.Infrastructure.Data.Contexts;

namespace VMRepresentacao.Infrastructure.Data
{
    public static class DbInitialize
    {
        public static void Initialize(Context context)
        {
            context.Database.EnsureCreated();

            CreateDataProduct(context);
            CreateDataCustomer(context);
        }

        private static void CreateDataCustomer(Context context)
        {
            if (context.Customers.Any())
                return;

            var customers = new Customer[]
            {
                new Customer("Construtora JBL", new Email("construtorajbl@email.com.br"), new CPF("39346850566"), new CNPJ("77729415000125")),
                new Customer("Rezende", new Email("rezende@email.com.br"), new CPF("50507391012"), new CNPJ("85371483000193")),
                new Customer("Leroy", new Email("leroy@email.com.br"), new CPF("85563454762"), new CNPJ("49852122000103")),
                new Customer("Mestre Atacadista", new Email("mestreatacadista@email.com.br"), new CPF("58348706780"), new CNPJ("16146634000197")),
                new Customer("TendTudo", new Email("TendTudo@email.com.br"), new CPF("45538638715"), new CNPJ("31788945000143"))
            };

            try
            {
                foreach (var customer in customers)
                {
                    context.Customers.Add(customer);
                }
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }

        }

        private static void CreateDataProduct(Context context)
        {
            if (context.Products.Any())
                return;

            var products = new Product[]
            {
                new Product("Piso Porcelanato", 42.90, "Piso para parte externa"),
                new Product("Cimento", 12.90, "Cimento extra qualidade"),
                new Product("Areia", 132.78, "Areia Lavada"),
                new Product("Tijolo", 45.32, "Milheiro de tijolo")
            };

            try
            {
                foreach (var product in products)
                {
                    context.Products.Add(product);
                }
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }

        }
    }
}
