namespace Lab18_State
{
    public partial class CandyMashine
    {
        public int CandyLeft { get; private set; }
        private IState _state;

        private void SetState(IState state)
        {
            if (state == null) 
            {
                throw new ArgumentNullException(nameof(state), "Состояние не может быть null");
            }
            _state = state;
        }

        public void EjectQuarter()
        {
            _state.EjectQuarter();
        }

        public void InsertQuarter()
        {
            _state.InsertQuarter();
        }

        public void TurnCrank()
        {
            _state.TurnCrank();
            Dispense();
        }

        private void Dispense()
        {
            _state.Dispense();
        }
    }
}
