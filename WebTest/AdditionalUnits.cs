namespace WebTest {
    class AdditionalUnits {
        public string unitname { get; set; }
        public Item item_0 { get; set; }
        public Item item_1 { get; set; }
        public Item item_2 { get; set; }
        public Item item_3 { get; set; }
        public Item item_4 { get; set; }
        public Item item_5 { get; set; }
        public Item backpack_0 { get; set; }
        public Item backpack_1 { get; set; }
        public Item backpack_2 { get; set; }

        public AdditionalUnits(int item_0, int item_1, int item_2, int item_3, int item_4, int item_5,
            int backpack_0, int backpack_1, int backpack_2) {
            this.item_0 = Items.getItemById(item_0);
            this.item_1 = Items.getItemById(item_1);
            this.item_2 = Items.getItemById(item_2);
            this.item_3 = Items.getItemById(item_3);
            this.item_4 = Items.getItemById(item_4);
            this.item_5 = Items.getItemById(item_5);
            this.backpack_0 = Items.getItemById(backpack_0);
            this.backpack_1 = Items.getItemById(backpack_1);
            this.backpack_2 = Items.getItemById(backpack_2);
        }
    }
}
