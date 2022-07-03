using Microsoft.AspNetCore.Mvc;
using Journal.Models;

namespace Journal.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class JournalController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<JournalItem> Get()
        {
            return Data.Journals;
        }

        [HttpPost]
        public JournalItem Post(JournalItem journal)
        {
            Data.Journals.Add(journal);
            return journal;
        }

        [HttpGet]
        public JournalItem? GetById(Guid guid)
        {
            return Data.Journals.Find(x => x.Id == guid);
        }

        [HttpPatch]
        public JournalItem? PatchById(JournalItem journalItem)
        {
            var item = Data.Journals.Find(x => x.Id == journalItem.Id);

            if (item != null)
            {
                item.FullName = journalItem.FullName;
                item.Date = journalItem.Date;
                item.Attendance = journalItem.Attendance;
            }
            return item;
        }

        [HttpDelete]
        public void DeleteById(Guid guid)
        {
            var item = Data.Journals.Find(x => x.Id == guid);
            if (item != null)
            {
                Data.Journals.Remove(item);
            }
        }
    }
}
