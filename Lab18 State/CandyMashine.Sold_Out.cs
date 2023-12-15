namespace Lab18_State
{
    public partial class CandyMashine
    {
        protected class Sold_out : IState
        {
            private CandyMashine _mashine;

            public Sold_out(CandyMashine candy)
            {
                if (candy == null)
                {
                    throw new ArgumentNullException(nameof(candy), "Объект не может быть null");
                }   
                _mashine = candy;
            }

            public void EjectQuarter()
            {
                Console.WriteLine("Монета возвращена");
            }

            public void InsertQuarter()
            {
                EjectQuarter();
            }

            public void TurnCrank()
            {
                Console.WriteLine("Ничего не произошло");
            }

            public void Dispense()
            {
                Console.WriteLine("Ничего не произошло");
            }
        }
    }
}
