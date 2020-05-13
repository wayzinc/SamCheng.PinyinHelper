/*!
 * Sam.Cheng Pinyin Helper
 * http://300830.com
 *
 * Copyright 2020 Sam.Cheng
 * Released under the MIT license
 *
 * Date: 2020-04-24
 */
namespace SamCheng.PinyinHelper.Core
{
    #region _Spaces
    using Data;
    using Model;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    #endregion

    public class PinyinUntil
    {
        #region _Variables
        //private static readonly string _NewLine = Environment.NewLine;
        private const char _NewSplitWord = '✸';
        private const char _NewLineWord = '✣';        
        #endregion

        #region Pinyin
        /// <summary>
        /// 获取拼音
        /// </summary>
        /// <param name="Word"></param>
        /// <returns></returns>
        public static List<List<string>> GetCNPinyin(string Word)
        {
            var _ResultData = new List<List<string>>() { };
            Word = Word.Trim().Replace("，", "，\n");

            foreach (var row in Word.Split(new string[] { "\n" }, StringSplitOptions.None))
            {
                var _WordArray = row.Replace(_NewSplitWord.ToString(), "").Replace(_NewLineWord.ToString(), "").ToCharArray();
                List<string> _Pinyins = new List<string>() { }, _Words = new List<string>() { };
                var _MultiPinyin = new string[_WordArray.Length];

                for (var i = 0; i < _WordArray.Length; i++)
                {
                    var _PinyinRow = "";
                    if (_MultiPinyin[i] != null)
                        _PinyinRow = _MultiPinyin[i];
                    else
                    {
                        var _PinyinData = SinglePinyin(_WordArray[i]);
                        _PinyinRow = _PinyinData != null ? _PinyinData.Pinyin : "";
                        if (i + 1 < _WordArray.Length)
                        {
                            var _MulitInfo = MultiPinyin(_WordArray[i].ToString() + _WordArray[i + 1].ToString());
                            if (_MulitInfo != null)
                            {
                                _PinyinRow = _MulitInfo[0];
                                _MultiPinyin[i + 1] = _MulitInfo[1];
                            }
                        }
                    }

                    _Pinyins.Add(_PinyinRow);
                    _Words.Add($"{_WordArray[i]}");
                }

                _ResultData.Add(_Pinyins);
                _ResultData.Add(_Words);
            }

            return _ResultData;
        }
        #endregion

        #region To WebJS-Array
        /// <summary>
        /// List 转 string
        /// </summary>
        /// <param name="Data"></param>
        /// <returns></returns>
        public static string ToWebJsArray(List<List<string>> Data)
        {
            var _PinyinResults = new StringBuilder();
            foreach (var row in Data)
            {
                var _SbItem = new StringBuilder();
                foreach (var item in row)
                    _SbItem.AppendFormat("{0}{1}", item, _NewSplitWord);
                _PinyinResults.Append(_SbItem.ToString().TrimEnd(_NewSplitWord));

                _PinyinResults.Append(_NewLineWord);
            }

            return _PinyinResults.ToString().TrimEnd(_NewLineWord);
        }
        #endregion

        #region Single
        /// <summary>
        /// 单字注音
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private static PinyinSingleInfo SinglePinyin(char str)
        {
            if (IsChinese(str))
            {
                var _PyInfo = Pinyin_Single.DictPinyin.Where(p => p.Key == str.ToString()).FirstOrDefault();
                if (_PyInfo.Key != null)
                    return new PinyinSingleInfo() { Pinyin = _PyInfo.Value[0], IsMulti = _PyInfo.Value.Length > 1 };
            }
            return null;
        }
        #endregion

        #region Multi
        /// <summary>
        /// 多音注音
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private static string[] MultiPinyin(string str)
        {
            if (str.Length >= 2)
            {
                var _PyInfo = Pinyin_Multi.DictPinyin.Where(p => p.Key == str.ToString()).FirstOrDefault();
                if (_PyInfo.Key != null)
                    return _PyInfo.Value;
            }
            return null;
        }
        #endregion

        #region Is-Chinese
        /// <summary>
        /// 是否中文
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private static bool IsChinese(char str)
        {
            return Convert.ToInt32(str) > 127;
        }
        #endregion
    }
}
