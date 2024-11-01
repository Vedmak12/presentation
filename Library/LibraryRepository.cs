using System.Collections.Generic;
using System.Linq;

namespace Library
{
    public class LibraryRepository : IBorrowable
    {
        private List<LibraryItem> _items = new List<LibraryItem>();
        private List<Member> _members = new List<Member>();
        private List<Loan> _loans = new List<Loan>();

        public void AddItem(LibraryItem item) => _items.Add(item);
        public void AddMember(Member member) => _members.Add(member);

        public List<LibraryItem> GetAllItems() => _items;

        public bool LoanItem(int itemId, int memberId)
        {
            var item = _items.FirstOrDefault(i => i.Id == itemId && i.IsAvailable);
            var member = _members.FirstOrDefault(m => m.Id == memberId);

            if (item != null && member != null)
            {
                item.IsAvailable = false;
                _loans.Add(new Loan { BookId = itemId, MemberId = memberId });
                return true;
            }
            return false;
        }

        
    }
}
