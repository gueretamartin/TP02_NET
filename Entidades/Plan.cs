namespace Entidades
{
    public  class Plan : BusinessEntity 
    {
        private string descripcionPlan;
        private Especialidad especialidad;

       
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
