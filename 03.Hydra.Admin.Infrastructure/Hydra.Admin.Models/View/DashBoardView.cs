﻿using Hydra.Admin.Utility.eChartControl;
using Hydra.Admin.Utility.iViewControl;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hydra.Admin.Models.View
{

    /// <summary>
    /// DashBoard
    /// </summary>
    public class DashBoardView
    {
        public DashBoardView()
        {
            this.xAxisData = new HashSet<string>();
            this.yAxisData = new Dictionary<string, IEnumerable<decimal>>();
        }
        /// <summary>
        /// DashBoard Item
        /// </summary>
        public List<decimal> DashBoardItem { get; set; }
        /// <summary>
        /// x 轴
        /// </summary>
        public IEnumerable<string> xAxisData { get; set; }
        /// <summary>
        /// y 轴
        /// </summary>
        public Dictionary<string, IEnumerable<decimal>> yAxisData { get; set; }
        /// <summary>
        /// table 
        /// </summary>
        public IViewTable<Model.AnalysisDashboard> Table { get; set; }
    }


    /// <summary>
    /// 在线情况
    /// </summary>
    public class PlayerOnlineView
    {
        public PlayerOnlineView()
        {
            this.xAxisData = new HashSet<string>();
            this.yAxisData = new HashSet<int>();
        }
        /// <summary>
        /// x 轴
        /// </summary>
        public IEnumerable<string> xAxisData { get; set; }
        /// <summary>
        /// y 轴
        /// </summary>
        public IEnumerable<int> yAxisData { get; set; }
        /// <summary>
        /// table 
        /// </summary>
        public IViewTable<dynamic> Table { get; set; }
    }


    /// <summary>
    /// 平台收支
    /// </summary>
    public class GameProfitView
    {
        public GameProfitView()
        {
            this.EChart = new EChartItem();
        }
        /// <summary>
        /// EChart
        /// </summary>
        public EChartItem EChart { get; set; }
        /// <summary>
        /// Table
        /// </summary>
        public IViewTable<dynamic> Table { get; set; }
    }
    /// <summary>
    /// 平台充值
    /// </summary>
    public class PlatRechargeView
    {
        public PlatRechargeView()
        {
            this.EChart = new EChartItem();
            this.TabExt = 0;
        }
        /// <summary>
        /// EChart
        /// </summary>
        public EChartItem EChart { get; set; }
        /// <summary>
        /// Table
        /// </summary>
        public IViewTable<dynamic> Table { get; set; }

        public decimal TabExt { get; set; }
    }
}
