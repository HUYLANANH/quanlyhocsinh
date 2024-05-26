using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QLY_HOCSINH.Models;

public partial class GnSoDauBai
{

    public int GnId { get; set; }

    [Display(Name = "Ngày")]
    public DateOnly? Ngay { get; set; }

    [Display(Name = "Tiết")]
    public string? Tiet { get; set; }

    [Display(Name = "Mã lớp")]
    public string? LopId { get; set; }

    [Display(Name = "Tên bài")]
    public string? TenBai { get; set; }

    [Display(Name = "Nội dung")]
    public string? NoiDung { get; set; }

    [Display(Name = "Xếp loại")]
    public string? XepLoai { get; set; }

    [Display(Name = "Mã lớp")]
    public virtual LopHoc? Lop { get; set; }
}
