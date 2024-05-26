using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QLY_HOCSINH.Models;

public partial class HocSinh
{
    [Display(Name = "Mã học sinh")]
    public string HsId { get; set; } = null!;

    [Display(Name = "Họ tên")]
    public string? HoTen { get; set; }

    [Display(Name = "Số điện thoại")]
    public int? Sdt { get; set; }

    [Display(Name = "Đại chỉ")]
    public string? Diachi { get; set; }

    [Display(Name = "Giới tính")]
    public string? Gioitinh { get; set; }

    public virtual ICollection<DiemDanh> DiemDanhs { get; set; } = new List<DiemDanh>();

    public virtual ICollection<XepLop> XepLops { get; set; } = new List<XepLop>();
}
