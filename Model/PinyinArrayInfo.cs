namespace SamCheng.PinyinHelper.Model
{
    /// <summary>
    /// 注音信息 实体
    /// </summary>
    public class PinyinListInfo
    {
        public string FirstWord { get; set; }
        public string FullWord { get; set; }
        public string[] PinyinArray { get; set; }
    }

    /// <summary>
    /// 单字注音 实体
    /// </summary>
    public class PinyinSingleInfo
    {
        public string Pinyin { get; set; }
        public bool IsMulti { get; set; }
    }
}
