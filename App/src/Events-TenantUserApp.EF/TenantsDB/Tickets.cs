namespace Events_TenantUserApp.EF.TenantsDB
{
    public partial class Tickets
    {
        public int VenueId { get; set; }
        public int TicketId { get; set; }
        public int RowNumber { get; set; }
        public int SeatNumber { get; set; }
        public int EventId { get; set; }
        public int SectionId { get; set; }
        public int TicketPurchaseId { get; set; }

        public virtual TicketPurchases TicketPurchases { get; set; }
        public virtual EventSections EventSections { get; set; }
    }
}
