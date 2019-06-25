using System.Threading;
using System.Threading.Tasks;
using WaterAddition.DAL.DataObjects;

namespace WaterAddition.DAL.DataServices.Mock {
	class MockMainDataService: BaseMockDataService, IMainDataService {
		public Task<RequestResult<SampleDataObject>> GetSampleDataObject(CancellationToken ctx) {
			return GetMockData<SampleDataObject>("WaterAddition.DAL.Resources.Mock.Main.SampleDataObject.json");
		}
	}
}

