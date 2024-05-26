using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QLY_HOCSINH.Models;

public partial class GnSoDauBai
{
    [Display(Name = "Ngày")]
    public DateOnly? Ngay { get; set; }

    [Display(Name = "Mã lớp")]
    public string? LopId { get; set; }

    [Display(Name = "Nội dung")]
    public string? Noidung { get; set; }

    [Display(Name = "Mã giáo viên")]
    public int GnId { get; set; }

    [Display(Name = "Mã lớp")]
    public virtual LopHoc? Lop { get; set; }
}
