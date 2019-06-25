using System.Threading;
using System.Threading.Tasks;
using WaterAddition.DAL.DataObjects;

namespace WaterAddition.DAL.DataServices {
	public interface IMainDataService {
		Task<RequestResult<SampleDataObject>> GetSampleDataObject(CancellationToken ctx);
	}
}

