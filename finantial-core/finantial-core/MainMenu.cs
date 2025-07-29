using fc_logic.ExpImp;
using fc_logic.Gastos;
using fc_logic.Investimentos;
using fc_logic.Relatorios;
using fc_logic.Rendimentos;

namespace finantial_core
{
    public class MainMenu
    {

        public void Menu() {

            int option = 0;

            do {                
                
                Console.WriteLine("BEM-VINDO");
                Console.WriteLine("O aplicativo para controlar suas finanças!");

                Console.WriteLine("1) Adicionar Gastos");
                Console.WriteLine("2) Adicionar Rendimentos");
                Console.WriteLine("3) Investimentos (WIP)");
                Console.WriteLine("4) Relatórios (WIP)");
                Console.WriteLine("5) Exportação/Importação (WIP)");
                Console.WriteLine("0) Sair do programa");

                Console.Write("\nEscolha sua opção: ");

                Option(option);

                option = Convert.ToInt32(Console.ReadLine());

            } while(option != 0);

            Console.WriteLine("Até a próxima!");
            Console.Beep();
            Console.Clear();                        

        }

        public void Option(int option) 
        {

            Gastos gastos_obj = new Gastos();
            Rendimentos rendimentos_obj = new Rendimentos();
            Investimentos investimenots_obj = new Investimentos();
            Relatorios relatorios_obj = new Relatorios();
            ExpImp expImp_main = new ExpImp();

            switch(option) 
            {

                case 1:
                    gastos_obj.GastosMain();
                    break;
                case 2:
                    rendimentos_obj.RendimentosMain();
                    break;
                case 3:
                    investimenots_obj.InvestimentosMain();
                    break;
                case 4:
                    relatorios_obj.RelatoriosMain();
                    break;
                case 5:
                    expImp_main.ExpImpMain();
                    break;

            }


        }

    }
}
