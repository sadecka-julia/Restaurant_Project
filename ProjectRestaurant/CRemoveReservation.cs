namespace ProjectRestaurant
{
    class CRemoveReservation : ICommand
    {
        private Restaurant _restaurant; 
        private int _IDToDelete;

        public CRemoveReservation(Restaurant restaurant, int reservationID)
        {
            _restaurant = restaurant;
            _IDToDelete = reservationID;
        }
        public void Execute()
        {
            for (int i = 0; i < _restaurant.reservationsHistory.Count; i++)
            {
                if( _restaurant.reservationsHistory[i].reservationID == _IDToDelete)
                {
                    _restaurant.reservationsHistory.RemoveAt(i);
                }
            }
        }
    }
}