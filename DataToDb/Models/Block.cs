﻿namespace DataToDb.Models
{
    public class Block
    {
        public string Id { get; set; }

        public BlockHeader Header { get; set; }

        public Transaction Transactions { get; set; }
    }
}
