namespace GameShop.Models
{
    public abstract class GridData
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public string SortDirection { get; set; } = string.Empty;
        public string SortField { get; set; } = string.Empty;

        public int GetTotalPages(int count) => (count + PageSize - 1) / PageSize;

        public void SetSortAndDirection(string newSortField, GridData current)
        {
            SortField = newSortField;

            if (current.SortField.EqualsNoCase(newSortField) && current.SortDirection == "asc")
            {
                SortDirection = "desc";
            }
            else
            {
                SortDirection = "asc";
            }
        }

        //copy self for passing
        public GridData Clone() => (GridData)MemberwiseClone();

        public virtual Dictionary<string, string> ToDictionary() =>
            new Dictionary<string, string> {
                {nameof(PageNumber), PageNumber.ToString() },
                {nameof(PageSize), PageSize.ToString() },
                {nameof(SortDirection), SortDirection },
                {nameof(SortField), SortField }
            };
    }
}
