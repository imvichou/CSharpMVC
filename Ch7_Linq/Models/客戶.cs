//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ch7_Linq.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class 客戶
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public 客戶()
        {
            this.訂貨主檔 = new HashSet<訂貨主檔>();
        }
    
        public string 客戶編號 { get; set; }
        public string 公司名稱 { get; set; }
        public string 連絡人 { get; set; }
        public string 連絡人職稱 { get; set; }
        public string 地址 { get; set; }
        public string 城市 { get; set; }
        public string 行政區 { get; set; }
        public string 郵遞區號 { get; set; }
        public string 國家地區 { get; set; }
        public string 電話 { get; set; }
        public string 傳真電話 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<訂貨主檔> 訂貨主檔 { get; set; }
    }
}
