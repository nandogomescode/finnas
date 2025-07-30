using fc_logic;

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

                this.Option(option);

                option = Convert.ToInt32(Console.ReadLine());

            } while(option != 0);

            Console.WriteLine("Até a próxima!");
            Console.Beep();
            Console.Clear();                        

        }

        private void Option(int option) 
        {

            var gastos_obj = new Gastos();
            var rendimentos_obj = new Rendimentos();
            var investimenots_obj = new Investimentos();
            var relatorios_obj = new Relatorios();
            var expImp_main = new ExpImp();

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
