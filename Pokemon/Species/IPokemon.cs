namespace PKHeXUtilLib.Pokemon.Species
{
    /// <summary>
    /// ポケモンの種族データのインターフェースです。
    /// </summary>
    public interface IPokemon
    {
        /// <summary>
        /// ポケモンの種族名を取得します。
        /// </summary>
        string Name { get; }

        /// <summary>
        /// ポケモンの全国図鑑番号を取得します。
        /// </summary>
        int Index { get; }

        /// <summary>
        /// ポケモンのフォルムIndexを取得します。
        /// </summary>
        int FormIndex { get; }

        /// <summary>
        /// タイプのIndexのリストを取得します。
        /// </summary>
        IReadOnlyList<int> Types { get; }

        /// <summary>
        /// HP種族値を取得します。
        /// </summary>
        int HpBase { get; }

        /// <summary>
        /// 攻撃種族値を取得します。
        /// </summary>
        int AtkBase { get; }

        /// <summary>
        /// 防御種族値を取得します。
        /// </summary>
        int DefBase { get; }

        /// <summary>
        /// 特攻種族値を取得します。
        /// </summary>
        int SpAtkBase { get; }

        /// <summary>
        /// 特防種族値を取得します。
        /// </summary>
        int SpDefBase { get; }

        /// <summary>
        /// 素早さ種族値を取得します。
        /// </summary>
        int SpdBase { get; }
    }
}
