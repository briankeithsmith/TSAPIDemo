﻿using System;
using System.Runtime.InteropServices;

namespace Tsapi
{
    using ATTPrivateData_t = Acs.PrivateData_t;
    public static partial class Att
    {

        public const int ATT_MAX_PRIVATE_DATA = 1024;
        public const int ATTPRIV_MAX_HEAP = 64;

        [StructLayout(LayoutKind.Sequential, Pack = 4, CharSet = CharSet.Ansi)]
        public struct ATTEventType_t
        {
            private int eventType;

            public ATTEventType_t(ushort value)
            {
                eventType = value;
            }

            public static implicit operator ATTEventType_t(ushort value)
            {
                return new ATTEventType_t(value);
            }

            public override string ToString()
            {
                return eventType.ToString();
            }
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4, CharSet = CharSet.Ansi)]
        public struct ATTEvent_t
        {
            public ATTEventType_t eventType;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = Att.ATTPRIV_MAX_HEAP)]
            private byte[] heap;

            // private version 6 
            public ATTSingleStepConferenceCallConfEvent_t ssconference
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTSingleStepConferenceCallConfEvent_t>(heap);
                }
            }
            ATTSelectiveListeningHoldConfEvent_t slhold
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTSelectiveListeningHoldConfEvent_t>(heap);
                }
            }
            ATTSelectiveListeningRetrieveConfEvent_t slretrieve
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTSelectiveListeningRetrieveConfEvent_t>(heap);
                }
            }
            ATTSendDTMFToneConfEvent_t sendDTMFTone
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTSendDTMFToneConfEvent_t>(heap);
                }
            }
            ATTQueryAcdSplitConfEvent_t queryAcdSplit
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTQueryAcdSplitConfEvent_t>(heap);
                }
            }
            ATTQueryAgentLoginConfEvent_t queryAgentLogin
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTQueryAgentLoginConfEvent_t>(heap);
                }
            }
            ATTQueryAgentLoginResp_t queryAgentLoginResp
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTQueryAgentLoginResp_t>(heap);
                }
            }
            ATTQueryAgentStateConfEvent_t queryAgentState
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTQueryAgentStateConfEvent_t>(heap);
                }
            }
            ATTQueryCallClassifierConfEvent_t queryCallClassifier
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTQueryCallClassifierConfEvent_t>(heap);
                }
            }
            ATTQueryDeviceInfoConfEvent_t queryDeviceInfo
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTQueryDeviceInfoConfEvent_t>(heap);
                }
            }
            ATTQueryDeviceNameConfEvent_t queryDeviceName
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTQueryDeviceNameConfEvent_t>(heap);
                }
            }
            ATTQueryMwiConfEvent_t queryMwi
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTQueryMwiConfEvent_t>(heap);
                }
            }
            ATTQueryStationStatusConfEvent_t queryStationStatus
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTQueryStationStatusConfEvent_t>(heap);
                }
            }
            ATTQueryTodConfEvent_t queryTod
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTQueryTodConfEvent_t>(heap);
                }
            }
            ATTQueryTgConfEvent_t queryTg
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTQueryTgConfEvent_t>(heap);
                }
            }
            ATTQueryAgentMeasurementsConfEvent_t queryAgentMeas
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTQueryAgentMeasurementsConfEvent_t>(heap);
                }
            }
            ATTQuerySplitSkillMeasurementsConfEvent_t querySplitSkillMeas
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTQuerySplitSkillMeasurementsConfEvent_t>(heap);
                }
            }
            ATTQueryTrunkGroupMeasurementsConfEvent_t queryTrunkGroupMeas
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTQueryTrunkGroupMeasurementsConfEvent_t>(heap);
                }
            }
            ATTQueryVdnMeasurementsConfEvent_t queryVdnMeas
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTQueryVdnMeasurementsConfEvent_t>(heap);
                }
            }
            ATTSnapshotDeviceConfEvent_t snapshotDevice
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTSnapshotDeviceConfEvent_t>(heap);
                }
            }
            ATTMonitorConfEvent_t monitorStart
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTMonitorConfEvent_t>(heap);
                }
            }
            ATTMonitorCallConfEvent_t monitorCallStart
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTMonitorCallConfEvent_t>(heap);
                }
            }
            ATTMonitorStopOnCallConfEvent_t monitorStopOnCall
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTMonitorStopOnCallConfEvent_t>(heap);
                }
            }
            ATTCallClearedEvent_t callClearedEvent
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTCallClearedEvent_t>(heap);
                }
            }
            ATTConferencedEvent_t conferencedEvent
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTConferencedEvent_t>(heap);
                }
            }
            ATTConnectionClearedEvent_t connectionClearedEvent
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTConnectionClearedEvent_t>(heap);
                }
            }
            ATTDeliveredEvent_t deliveredEvent
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTDeliveredEvent_t>(heap);
                }
            }
            ATTEnteredDigitsEvent_t enteredDigitsEvent
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTEnteredDigitsEvent_t>(heap);
                }
            }
            ATTEstablishedEvent_t establishedEvent
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTEstablishedEvent_t>(heap);
                }
            }
            ATTLoggedOnEvent_t loggedOnEvent
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTLoggedOnEvent_t>(heap);
                }
            }
            ATTNetworkReachedEvent_t networkReachedEvent
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTNetworkReachedEvent_t>(heap);
                }
            }
            ATTOriginatedEvent_t originatedEvent
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTOriginatedEvent_t>(heap);
                }
            }
            ATTTransferredEvent_t transferredEvent
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTTransferredEvent_t>(heap);
                }
            }
            ATTRouteRequestEvent_t routeRequest
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTRouteRequestEvent_t>(heap);
                }
            }
            ATTRouteUsedEvent_t routeUsed
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTRouteUsedEvent_t>(heap);
                }
            }
            ATTLinkStatusEvent_t linkStatus
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTLinkStatusEvent_t>(heap);
                }
            }
            ATTGetAPICapsConfEvent_t getAPICaps
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTGetAPICapsConfEvent_t>(heap);
                }
            }
            ATTServiceInitiatedEvent_t serviceInitiated
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTServiceInitiatedEvent_t>(heap);
                }
            }
            ATTChargeAdviceEvent_t chargeAdviceEvent
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTChargeAdviceEvent_t>(heap);
                }
            }
            ATTSetBillRateConfEvent_t setBillRate
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTSetBillRateConfEvent_t>(heap);
                }
            }

            public ATTQueryUcidConfEvent_t queryUCID
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTQueryUcidConfEvent_t>(heap);
                }
            }

            ATTLoggedOffEvent_t loggedOffEvent
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTLoggedOffEvent_t>(heap);
                }
            }

            ATTConsultationCallConfEvent_t consultationCall
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTConsultationCallConfEvent_t>(heap);
                }
            }

            public ATTConferenceCallConfEvent_t conferenceCall
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTConferenceCallConfEvent_t>(heap);
                }
            }

            ATTMakeCallConfEvent_t makeCall
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTMakeCallConfEvent_t>(heap);
                }
            }

            ATTMakePredictiveCallConfEvent_t makePredictiveCall
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTMakePredictiveCallConfEvent_t>(heap);
                }
            }

            ATTTransferCallConfEvent_t transferCall
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTTransferCallConfEvent_t>(heap);
                }
            }

            ATTSetAdviceOfChargeConfEvent_t setAdviceOfCharge
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTSetAdviceOfChargeConfEvent_t>(heap);
                }
            }

            ATTSetAgentStateConfEvent_t setAgentState
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTSetAgentStateConfEvent_t>(heap);
                }
            }


            // the following are obsolete as of protocol version 4 and should not be used 

            ATTV3ConferencedEvent_t v3conferencedEvent
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTV3ConferencedEvent_t>(heap);
                }
            }

            ATTV3DeliveredEvent_t v3deliveredEvent
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTV3DeliveredEvent_t>(heap);
                }
            }

            ATTV3EstablishedEvent_t v3establishedEvent
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTV3EstablishedEvent_t>(heap);
                }
            }
            ATTV3TransferredEvent_t v3transferredEvent
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTV3TransferredEvent_t>(heap);
                }
            }
            ATTV3LinkStatusEvent_t v3linkStatus
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTV3LinkStatusEvent_t>(heap);
                }
            }

            // version 4 events
            ATTV4QueryDeviceInfoConfEvent_t v4queryDeviceInfo
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTV4QueryDeviceInfoConfEvent_t>(heap);
                }
            }
            ATTV4GetAPICapsConfEvent_t v4getAPICaps
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTV4GetAPICapsConfEvent_t>(heap);
                }
            }
            ATTV4SnapshotDeviceConfEvent_t v4snapshotDevice
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTV4SnapshotDeviceConfEvent_t>(heap);
                }
            }
            ATTV4ConferencedEvent_t v4conferencedEvent
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTV4ConferencedEvent_t>(heap);
                }
            }
            ATTV4DeliveredEvent_t v4deliveredEvent
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTV4DeliveredEvent_t>(heap);
                }
            }
            ATTV4EstablishedEvent_t v4establishedEvent
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTV4EstablishedEvent_t>(heap);
                }
            }
            ATTV4TransferredEvent_t v4transferredEvent
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTV4TransferredEvent_t>(heap);
                }
            }
            ATTV4LinkStatusEvent_t v4linkStatus
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTV4LinkStatusEvent_t>(heap);
                }
            }
            ATTV4RouteRequestEvent_t v4routeRequest
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTV4RouteRequestEvent_t>(heap);
                }
            }
            ATTV4QueryAgentStateConfEvent_t v4queryAgentState
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTV4QueryAgentStateConfEvent_t>(heap);
                }
            }
            ATTV4QueryDeviceNameConfEvent_t v4queryDeviceName
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTV4QueryDeviceNameConfEvent_t>(heap);
                }
            }
            ATTV4MonitorConfEvent_t v4monitorStart
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTV4MonitorConfEvent_t>(heap);
                }
            }
            ATTV4MonitorCallConfEvent_t v4monitorCallStart
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTV4MonitorCallConfEvent_t>(heap);
                }
            }
            ATTV4NetworkReachedEvent_t v4networkReachedEvent
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTV4NetworkReachedEvent_t>(heap);
                }
            }

            // version 5 events
            ATTV5QueryAgentStateConfEvent_t v5queryAgentState
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTV5QueryAgentStateConfEvent_t>(heap);
                }
            }
            ATTV5RouteRequestEvent_t v5routeRequest
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTV5RouteRequestEvent_t>(heap);
                }
            }
            ATTV5TransferredEvent_t v5transferredEvent
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTV5TransferredEvent_t>(heap);
                }
            }
            ATTV5ConferencedEvent_t v5conferencedEvent
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTV5ConferencedEvent_t>(heap);
                }
            }
            ATTV5ConnectionClearedEvent_t v5connectionClearedEvent
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTV5ConnectionClearedEvent_t>(heap);
                }
            }
            ATTV5OriginatedEvent_t v5originatedEvent
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTV5OriginatedEvent_t>(heap);
                }
            }
            ATTV5EstablishedEvent_t v5establishedEvent
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTV5EstablishedEvent_t>(heap);
                }
            }
            ATTV5DeliveredEvent_t v5deliveredEvent
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTV5DeliveredEvent_t>(heap);
                }
            }


            // events received by the G3PD 

            public ATTClearConnection_t clearConnectionReq
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTClearConnection_t>(heap);
                }
            }

            ATTConsultationCall_t				consultationCallReq
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTConsultationCall_t>(heap);
                }
            }
            ATTMakeCall_t						makeCallReq
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTMakeCall_t>(heap);
                }
            }
            ATTDirectAgentCall_t				directAgentCallReq
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTDirectAgentCall_t>(heap);
                }
            }
            ATTMakePredictiveCall_t				makePredictiveCallReq
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTMakePredictiveCall_t>(heap);
                }
            }
            ATTSupervisorAssistCall_t			supervisorAssistCallReq
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTSupervisorAssistCall_t>(heap);
                }
            }
            ATTReconnectCall_t					reconnectCallReq
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTReconnectCall_t>(heap);
                }
            }
            ATTSendDTMFTone_t					sendDTMFToneReq
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTSendDTMFTone_t>(heap);
                }
            }
            ATTSingleStepConferenceCall_t       ssconferenceReq
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTSingleStepConferenceCall_t>(heap);
                }
            }
            ATTSelectiveListeningHold_t         slholdReq
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTSelectiveListeningHold_t>(heap);
                }
            }
            ATTSelectiveListeningRetrieve_t     slretrieveReq
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTSelectiveListeningRetrieve_t>(heap);
                }
            }
            ATTSetAgentState_t					setAgentStateReq
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTSetAgentState_t>(heap);
                }
            }
            ATTQueryAgentState_t				queryAgentStateReq
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTQueryAgentState_t>(heap);
                }
            }
            ATTQueryAcdSplit_t					queryAcdSplitReq
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTQueryAcdSplit_t>(heap);
                }
            }
            ATTQueryAgentLogin_t				queryAgentLoginReq
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTQueryAgentLogin_t>(heap);
                }
            }
            ATTQueryCallClassifier_t			queryCallClassifierReq
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTQueryCallClassifier_t>(heap);
                }
            }
            ATTQueryDeviceName_t				queryDeviceNameReq
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTQueryDeviceName_t>(heap);
                }
            }
            ATTQueryStationStatus_t				queryStationStatusReq
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTQueryStationStatus_t>(heap);
                }
            }
            ATTQueryTod_t						queryTodReq
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTQueryTod_t>(heap);
                }
            }
            ATTQueryTg_t						queryTgReq
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTQueryTg_t>(heap);
                }
            }
            ATTQueryAgentMeasurements_t			queryAgentMeasReq
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTQueryAgentMeasurements_t>(heap);
                }
            }
            ATTQuerySplitSkillMeasurements_t	querySplitSkillMeasReq
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTQuerySplitSkillMeasurements_t>(heap);
                }
            }
            ATTQueryTrunkGroupMeasurements_t	queryTrunkGroupMeasReq
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTQueryTrunkGroupMeasurements_t>(heap);
                }
            }
            ATTQueryVdnMeasurements_t			queryVdnMeasReq
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTQueryVdnMeasurements_t>(heap);
                }
            }
            ATTMonitorFilter_t					monitorFilterReq
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTMonitorFilter_t>(heap);
                }
            }
            ATTMonitorStopOnCall_t				monitorStopOnCallReq
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTMonitorStopOnCall_t>(heap);
                }
            }
            ATTRouteSelect_t					routeSelectReq
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTRouteSelect_t>(heap);
                }
            }
            ATTSysStat_t						sysStatReq
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTSysStat_t>(heap);
                }
            }
            ATTSetBillRate_t					setBillRateReq
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTSetBillRate_t>(heap);
                }
            }
            ATTQueryUcid_t						queryUCIDReq
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTQueryUcid_t>(heap);
                }
            }
            ATTSetAdviceOfCharge_t				adviceOfChargeReq
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTSetAdviceOfCharge_t>(heap);
                }
            }

            // private data version 4

            ATTV4SendDTMFTone_t					v4sendDTMFToneReq
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTV4SendDTMFTone_t>(heap);
                }
            }
            ATTV4SetAgentState_t				v4setAgentStateReq
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTV4SetAgentState_t>(heap);
                }
            }
            ATTV4MonitorFilter_t				v4monitorFilterReq
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTV4MonitorFilter_t>(heap);
                }
            }

            // version 5 of private data
            ATTV5SetAgentState_t				v5setAgentStateReq
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTV5SetAgentState_t>(heap);
                }
            }
            ATTV5ClearConnection_t				v5clearConnectionReq
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTV5ClearConnection_t>(heap);
                }
            }
            ATTV5ConsultationCall_t				v5consultationCallReq
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTV5ConsultationCall_t>(heap);
                }
            }
            ATTV5MakeCall_t						v5makeCallReq
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTV5MakeCall_t>(heap);
                }
            }
            ATTV5DirectAgentCall_t				v5directAgentCallReq
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTV5DirectAgentCall_t>(heap);
                }
            }
            ATTV5MakePredictiveCall_t			v5makePredictiveCallReq
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTV5MakePredictiveCall_t>(heap);
                }
            }
            ATTV5SupervisorAssistCall_t			v5supervisorAssistCallReq
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTV5SupervisorAssistCall_t>(heap);
                }
            }
            ATTV5ReconnectCall_t				v5reconnectCallReq
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTV5ReconnectCall_t>(heap);
                }
            }
            ATTV5RouteSelect_t					v5routeSelectReq
            {
                get
                {
                    return Aux.ByteArrayToStructure<ATTV5RouteSelect_t>(heap);
                }
            }
        }

        [DllImport("ATTPRV32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern Acs.RetCode_t attQueryUCID(
                            [In, Out]
                            Acs.PrivateData_t privData,
                            ref Csta.ConnectionID_t call);

        [DllImport("ATTPRV32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern Acs.RetCode_t attClearConnection(
                            [In, Out]
                            Acs.PrivateData_t privData,
                            ATTDropResource_t dropResource,
                            ref ATTV5UserToUserInfo_t userInfo);

        [DllImport("ATTPRV32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern Acs.RetCode_t attV6ClearConnection(
                            [In, Out]
                            Acs.PrivateData_t privData,
                            ATTDropResource_t dropResource,
                            ref ATTV5UserToUserInfo_t userInfo);

        [DllImport("ATTPRV32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern Acs.RetCode_t attConsultationCall(
                            [In, Out]
                            Acs.PrivateData_t privData,
                            Csta.DeviceID_t deviceRoute,
                            bool priorityCalling,
                            ref ATTV5UserToUserInfo_t userInfo);

        [DllImport("ATTPRV32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern Acs.RetCode_t attV6ConsultationCall(
                            [In, Out]
                            Acs.PrivateData_t privData,
                            Csta.DeviceID_t deviceRoute,
                            bool priorityCalling,
                            ref ATTV5UserToUserInfo_t userInfo);


        [DllImport("ATTPRV32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern Acs.RetCode_t attMakeVersionString(
                            string requestedVersion,
                            System.Text.StringBuilder supportedVersion);


        // Decode ATTPrivateData
        [DllImport("ATTPRV32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern Acs.RetCode_t attPrivateData(
                            [In, Out]
                            Acs.PrivateData_t privData,
                            out ATTEvent_t eventBuffer);



    }
}