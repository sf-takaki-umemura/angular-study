using System.ComponentModel.DataAnnotations;

namespace AspNetCoreSpa.Server.Entities
{
    public enum ExternalLoginStatus
    {
        Ok = 0,
        Error = 1,
        Invalid = 2,
        TwoFactor = 3,
        Lockout = 4,
        CreateAccount = 5

    }

    /// <summary>
    /// �Ζ����
    /// </summary>
    public enum WorkingType
    {
        /// <summary>
        /// ���o�^
        /// </summary>
        [Display(Name = "���o�^")]
        Unregistered = 0,
        /// <summary>
        /// �o��
        /// </summary>
        [Display(Name = "�o��")]
        Attendance = 1,
        /// <summary>
        /// �L���x��
        /// </summary>
        [Display(Name = "�L���x��")]
        PaidHoliday = 20,
        /// <summary>
        /// �@���x��
        /// </summary>
        [Display(Name = "�@���x��")]
        LegalHoliday = 10,
        /// <summary>
        /// �@��O�x��
        /// </summary>
        [Display(Name = "�@��O�x��")]
        NonLegalHoliday = 11,

    }
}