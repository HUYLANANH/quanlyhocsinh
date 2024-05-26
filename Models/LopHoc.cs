using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QLY_HOCSINH.Models;

public partial class LopHoc
{
    [Display(Name = "Mã lớp")]
    public string LopId { get; set; } = null!;

    [Display(Name = "Tên lớp")]
    public string? TenLop { get; set; }

    [Display(Name = "Mã giáo viên")]
    public string? GvId { get; set; }

    public virtual ICollection<DiemDanh> DiemDanhs { get; set; } = new List<DiemDanh>();

    public virtual ICollection<GnSoDauBai> GnSoDauBais { get; set; } = new List<GnSoDauBai>();

    public virtual GiaoVien? Gv { get; set; }

    public virtual ICollection<XepLop> XepLops { get; set; } = new List<XepLop>();
}
