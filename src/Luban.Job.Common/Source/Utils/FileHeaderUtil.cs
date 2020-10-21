namespace Luban.Job.Common.Utils
{
    public static class FileHeaderUtil
    {
        const string AUTO_GENERATE_C_LIKE = @"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
";


        const string AUTO_GENERATE_LUA = @"
--[[------------------------------------------------------------------------------
-- <auto-generated>
--     This code was generated by a tool.
--     Changes to this file may cause incorrect behavior and will be lost if
--     the code is regenerated.
-- </auto-generated>
--]]------------------------------------------------------------------------------
";

        const string AUTO_GENERATE_PYTHON = @"
'''
  <auto-generated>
    This code was generated by a tool.
    Changes to this file may cause incorrect behavior and will be lost if
    the code is regenerated.
  </auto-generated>
'''
";

        public static string ConcatAutoGenerationHeader(string txt, ELanguage lan)
        {
            switch (lan)
            {
                case ELanguage.LUA: return AUTO_GENERATE_LUA + txt;
                case ELanguage.PYTHON: return AUTO_GENERATE_PYTHON + txt;
                default: return AUTO_GENERATE_C_LIKE + txt;
            }
        }
    }
}
