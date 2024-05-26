using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QLY_HOCSINH.Models;

public partial class GiaoVien
{
    [Display(Name = "Mã giáo viên")]
    public string GvId { get; set; } = null!;

    [Display(Name = "Họ tên")]
    public string? HoTen { get; set; }

    [Display(Name = "Tài khoản ")]
    public string? TaiKhoan { get; set; }

    [Display(Name = "Mật khẩu")]
    public string? MatKhau { get; set; }

    [Display(Name = "Email")]
    public string? Email { get; set; }

    public virtual ICollection<LopHoc> LopHocs { get; set; } = new List<LopHoc>();
}
