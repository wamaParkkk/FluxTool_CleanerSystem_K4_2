﻿namespace FluxTool_CleanerSystem_K4_2
{
    //**************************************************************************************************
    // Config에서 Analog Channel을 읽는 구조체
    public struct TANA
    {
        public int total;           //표시 할 전체 자리수
        public int dec;             //표시 할 소수점의 자리수
        public int min;             //analog값에 대한 최소치
        public int max;             //analog값에 대한 최대치        
    }
    //**************************************************************************************************

    //**************************************************************************************************
    // Config에서 Digital Channel을 읽는 구조체
    public struct TDIG
    {
        //
    }
    //**************************************************************************************************
}