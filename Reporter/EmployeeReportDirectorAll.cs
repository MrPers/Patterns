namespace Reporter
{
    public class EmployeeReportDirectorAll
    {
        private readonly IEmployeeReportBuilder _builder;

        public EmployeeReportDirectorAll(IEmployeeReportBuilder builder)
        {
            _builder = builder;
        }

        public void Build()
        {
            _builder
                .BuildHeader()
                .BuildBody()
                .BuildFooter();
        }
    }

    public class EmployeeReportDirectorRandom
    {
        private readonly IEmployeeReportBuilder _builder;

        public EmployeeReportDirectorRandom(IEmployeeReportBuilder builder)
        {
            _builder = builder;
        }

        public void Build()
        {
            Random random = new Random();
            switch (random.Next(3))
            {
                case 0:
                    _builder
                .BuildBody();
                    break;
                case 1:
                    _builder
                .BuildHeader()
                .BuildBody();
                    break;
                case 2:
                    _builder
                .BuildBody()
                .BuildFooter();
                    break;
            }
        }


    }
}
