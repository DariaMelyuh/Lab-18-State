namespace Lab18_State
{
    public partial class CandyMashine
    {
        protected class Sold : IState
        {
            private CandyMashine _mashine;

            public Sold(CandyMashine candy)
            {
                if (candy == null)
                {
                    throw new ArgumentNullException(nameof(candy), "Объект не может быть null");
                }   
                _mashine = candy;
            }

            public void EjectQuarter()
            {
                Console.WriteLine("Ничего не произошло");
            }

            public void InsertQuarter()
            {
                Console.WriteLine("Ничего не произошло");
            }

            public void TurnCrank()
            {
                Console.WriteLine("Ничего не произошло");
            }

            public void Dispense()
            {
                Console.WriteLine("Конфета выдана");
                _mashine.SetState(_mashine.CandyLeft > 0 ? new No_quarters(_mashine) : new Sold_out(_mashine));
            }
        }
    }
}
