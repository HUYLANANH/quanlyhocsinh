using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QLY_HOCSINH.Models;

public partial class DiemDanh
{
    [Display(Name = "Mã điểm danh")]
    public int DiemDanhId { get; set; }

    [Display(Name = "Mã lớp")]
    public string? LopId { get; set; }

    [Display(Name = "Ngày")]
    public DateOnly? Ngay { get; set; }

    [Display(Name = "Mã học sinh")]
    public string? HsId { get; set; }

    [Display(Name = "Trạng thái")]
    public string? TrangThai { get; set; }

    [Display(Name = "Mã học sinh")]
    public virtual HocSinh? Hs { get; set; }

    [Display(Name = "Mã lớp")]
    public virtual LopHoc? Lop { get; set; }
}
