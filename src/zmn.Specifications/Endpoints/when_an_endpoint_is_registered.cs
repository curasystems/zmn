using Machine.Specifications;

namespace zmn.Specifications.Endpoints
{
    [Subject("registering endpoints")]
    public class when_an_endpoint_is_registered
    {
        Establish context = () =>
                {
                    _bus = new zmn.Bus();
                    _endpointName = "arbitrary:service:name";
                };

        Because of = () =>
                _bus.RegisterEndpoint( _endpointName );

        It should_be_listed_on_the_bus = () =>
                _bus.KnowsEndpoint(_endpointName).ShouldBeTrue();
        
        private static Bus _bus;
        private static string _endpointName;
    }
}

