using Service.Requests;
using Service.Responses;
using System.ServiceModel;

namespace Service
{
    // ПРИМЕЧАНИЕ. Можно использовать команду "Переименовать" в меню "Рефакторинг", чтобы изменить имя интерфейса "IServiceContext" в коде и файле конфигурации.
    [ServiceContract]
    public interface IServiceContext
    {
        [OperationContract]
        BaseResponse Autorization(AutorizationRequest request);
        [OperationContract]
        BaseResponse Registration(Registration request);
        [OperationContract]
        BaseResponse OrderFood(OrderFoodRequest request);
    }
}
