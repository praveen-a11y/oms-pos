namespace OMS.Api
{
    public class DependencyConfig
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<Services.IUserAuthService, Services.UserAuthService>();

            services.AddTransient<DAL.IDataAccessRepository.IUserRepository, DAL.DataAccessRepository.UserRepository>();
            services.AddTransient<BLL.IBusinessComponent.IUserComponent, BLL.BusinessComponent.UserComponent>();

            services.AddTransient<DAL.IDataAccessRepository.IItemRepository, DAL.DataAccessRepository.ItemRepository>();
            services.AddTransient<BLL.IBusinessComponent.IItemComponent, BLL.BusinessComponent.ItemComponent>();

            services.AddTransient<DAL.IDataAccessRepository.IOrderRepository, DAL.DataAccessRepository.OrderRepository>();
            services.AddTransient<BLL.IBusinessComponent.IOrderComponent, BLL.BusinessComponent.OrderComponent>();

            services.AddTransient<DAL.IDataAccessRepository.IOrderReportRepository, DAL.DataAccessRepository.OrderReportRepository>();
            services.AddTransient<BLL.IBusinessComponent.IOrderReportComponent, BLL.BusinessComponent.OrderReportComponent>();

        }
    }
}
