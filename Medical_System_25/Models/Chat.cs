﻿using System;
using System.Collections.Generic;

namespace Medical_System.Models
{
    public class Chat
    {
        public int Id { get; set; }
        public int doctor_id { get; set; }
        public int person_id { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public string name { get; set; }
        public Chat(List<object> select)
        {
            Id = Convert.ToInt32(select[0].ToString());
            doctor_id = Convert.ToInt32(select[1].ToString());
            person_id = Convert.ToInt32(select[2].ToString());
            Text = select[3].ToString();
            Date = Convert.ToDateTime(select[4].ToString());
            name = select[5].ToString();
        }
    }
}
