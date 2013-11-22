﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Senparc.Weixin.MP.P2PSDK.Common
{
    /// <summary>
    /// P2P返回结果类型
    /// </summary>
    public enum P2PResultKind
    {
        成功 = 0,
        账户验证失败 = -1000,

        账户被停用 = -2000,
        账户被停用_尚未通过审核 = -2001,
        账户被停用_已关闭 = -2002,
        账户被停用_状态异常 = -2003,

        包含违法信息 = -3000,

        执行过程发生异常 = -4000,
        执行过程发生异常_API地址错误 = -4001,
        执行过程发生异常_积分不足 = -4002,

        发送消息失败 = -5000,
        发送消息失败_用户不存在 = -5001,
        发送消息失败_需要验证码 = -5003,
        发送消息失败_请求被禁止 = -5005,
        发送消息失败_不能发送_对方不是你的粉丝 = -5006,
        发送消息失败_对方关闭了接收消息 = -5007,
        发送消息失败_该用户已被加入黑名单_无法向此发送消息 = -5008,
        发送消息失败_引用错误 = -5009,
        发送消息失败_NeedPost = -5010,
        发送消息失败_24小时内用户未互动 = -5011,

        P2PBridge错误 = -6000,
        P2PBridge错误_Url未正确设置 = -6001,

        资源获取失败 = -7000,
        资源获取失败_资源不存在 = -7001,
        资源获取失败_音频时间太长 = -7002,
        资源获取失败_参数错误 = -7003
        //P2PServer进程注册失败 = -9000,
    }

    /// <summary>
    /// 性别
    /// </summary>
    public enum WeixinSex
    {
        未设置 = 0,
        男 = 1,
        女 = 2,
    }
}
