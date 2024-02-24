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

    public class EmployeeReportDirectorOnlyBody
    {
        private readonly IEmployeeReportBuilder _builder;

        public EmployeeReportDirectorOnlyBody(IEmployeeReportBuilder builder)
        {
            _builder = builder;
        }

        public void Build()
        {
            _builder
                .BuildBody();
        }
    }
}
