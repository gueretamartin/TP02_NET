namespace Entidades
{
    public  class Plan : BusinessEntity 
    {
        private int idPlan;
        private string descripcionPlan;
        private Especialidad especialidad;

       
        public int IdPlan
        {
            get
            {
                return idPlan;
            }

            set
            {
                idPlan = value;
            }
        }
        public string DescripcionPlan
        {
            get
            {
                return descripcionPlan;
            }

            set
            {
                descripcionPlan = value;
            }
        }

        public Especialidad Especialidad
        {
            get
            {
                return especialidad;
            }

            set
            {
                especialidad = value;
            }
        }
    }
}
