using System;
using System.Linq;
using VMRepresentacao.Domain.Entities;
using VMRepresentacao.Domain.Enumerators;
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
            CreateDataCompany(context);
        }

        private static void CreateDataCompany(Context context)
        {
            if (context.Companies.Any())
                return;

            var listCompany = new Company[]
            {
                new Company("VMRepresentaçoes Matrix Ltda", new CNPJ("27905534000113"), TypeOfSubsidiary.Matrix, new Email("vmrepresentacoes.matriz@gmail.com"), new Address("Avenida João Angelino dos Santos", new ZipCode("57330970"), States.AL, "Lagoa da Canoa", 0, "Centro", TypeOfAddress.Work, "Ao Lado do pão de açucar"), new Telephone[] { new Telephone(21, "555555555", TypeOfTelephone.Message), new Telephone(34, "444444444", TypeOfTelephone.Residential), new Telephone(82, "333333333", TypeOfTelephone.CellPhone), new Telephone(96, "222222222", TypeOfTelephone.Fax) })

                ,new Company("VMRepresentaçoes Filial Ltda", new CNPJ("18173642000158"), TypeOfSubsidiary.Branch, new Email("vmrepresentacoes.Filial@gmail.com"), new Address("Avenida General Asdrúbal da Cunha ", new ZipCode("05565900"), States.SP, "São Paulo", 1344, "Jardim Arpoador", TypeOfAddress.Work, "Ao Lado do pão de açucar"), new Telephone[] { new Telephone(21, "555555555", TypeOfTelephone.Message), new Telephone(34, "444444444", TypeOfTelephone.Residential), new Telephone(82, "333333333", TypeOfTelephone.CellPhone), new Telephone(96, "222222222", TypeOfTelephone.Fax) }),

                new Company("VMRepresentaçoes Ltda", new CNPJ("86746586000153"), TypeOfSubsidiary.Franchise, new Email("vmrepresentacoes.franquia@gmail.com"), new Address("Avenida João Angelino dos Santos", new ZipCode("92200480"), States.AM, "Manaus", 0, "Novo Aleixo", TypeOfAddress.Work, "Ao Lado do pão de açucar"), new Telephone[] { new Telephone(21, "555555555", TypeOfTelephone.Message), new Telephone(34, "444444444", TypeOfTelephone.Residential), new Telephone(82, "333333333", TypeOfTelephone.CellPhone), new Telephone(96, "222222222", TypeOfTelephone.Fax) })
            };

            try
            {
                foreach (var company in listCompany)
                {
                    context.Companies.Add(company);
                }
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        private static void CreateDataCustomer(Context context)
        {
            if (context.Customers.Any())
                return;

            var customers = new Customer[]
            {
                new Customer("Construtora JBL", new Email("construtorajbl@email.com.br"), new CPF("39346850566"), new CNPJ("77729415000125"), new Address("Avenida Presidente Vargas", new ZipCode("75903-290"), Domain.Enumerators.States.GO, "Rio Verde", 2776, "Jd Goiás", Domain.Enumerators.TypeOfAddress.Work, "Araújo Com de Pneus"), new Telephone[] {new Telephone(61, "999999999", TypeOfTelephone.CellPhone), new Telephone(11, "888888888", TypeOfTelephone.Fax), new Telephone(33, "777777777", TypeOfTelephone.Job),new Telephone(64, "666666666", TypeOfTelephone.Residential)}),

                new Customer("Rezende", new Email("rezende@email.com.br"), new CPF("50507391012"), new CNPJ("85371483000193"), new Address("Rua Frei Inocêncio", new ZipCode("35290-000"), Domain.Enumerators.States.MG, "Mantena", 229, "Centro", Domain.Enumerators.TypeOfAddress.Work, "Centro Automotivo R & E"), new Telephone[] {new Telephone(61, "999999999", TypeOfTelephone.CellPhone), new Telephone(11, "888888888", TypeOfTelephone.Fax), new Telephone(33, "777777777", TypeOfTelephone.Job),new Telephone(64, "666666666", TypeOfTelephone.Residential)}),

                new Customer("Leroy", new Email("leroy@email.com.br"), new CPF("85563454762"), new CNPJ("49852122000103"), new Address("Rua Gibraltar", new ZipCode("04755-070"), Domain.Enumerators.States.SP, "São Paulo", 131, "Santo Amaro", Domain.Enumerators.TypeOfAddress.Billing, "Casa Fernandes Pneus - Centro de Distribuição"), new Telephone[] {new Telephone(61, "999999999", TypeOfTelephone.CellPhone), new Telephone(11, "888888888", TypeOfTelephone.Fax), new Telephone(33, "777777777", TypeOfTelephone.Job),new Telephone(64, "666666666", TypeOfTelephone.Residential)}),

                new Customer("Mestre Atacadista", new Email("mestreatacadista@email.com.br"), new CPF("58348706780"), new CNPJ("16146634000197"), new Address("Rua A,Via Local 1,Faz.Grande II Jaguaribe", new ZipCode("41342125"), Domain.Enumerators.States.BA, "Salvador ", 7, "Cajazeiras ", Domain.Enumerators.TypeOfAddress.Work, "J & M Alinhamentos E Balanceamento"), new Telephone[] {new Telephone(61, "999999999", TypeOfTelephone.CellPhone), new Telephone(11, "888888888", TypeOfTelephone.Fax), new Telephone(33, "777777777", TypeOfTelephone.Job),new Telephone(64, "666666666", TypeOfTelephone.Residential)}),

                new Customer("TendTudo", new Email("TendTudo@email.com.br"), new CPF("45538638715"), new CNPJ("31788945000143"), new Address("Rua 12 chácara 145", new ZipCode("72007525"), Domain.Enumerators.States.DF, "Brasília", 17, "Vicente Pires", Domain.Enumerators.TypeOfAddress.Home, "Rua 12 da vicente pires guarita azul"), new Telephone[] {new Telephone(61, "999999999", TypeOfTelephone.CellPhone), new Telephone(11, "888888888", TypeOfTelephone.Fax), new Telephone(33, "777777777", TypeOfTelephone.Job),new Telephone(64, "666666666", TypeOfTelephone.Residential)})
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
