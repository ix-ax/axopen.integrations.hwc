USING AXOpen.Integrations.Hwc;

{S7.extern=ReadWrite}
CLASS SandboxContext EXTENDS AXOpen.Core.AxoContext

    VAR PUBLIC
        _manualControl : BOOL;
        _testCyclinder : AXOpen.Integrations.Hwc.TemplateComponent;
        _homeSensor : BOOL;
        _workSensor : BOOL;    
        _moveHomeSignal : BOOL;
        _moveWorkSignal : BOOL;
        _data : ARRAY [0..0] OF BYTE;
        _retvalAventics : WORD;
        _retvalFesto : WORD;
        _retvalET200 : WORD;
    END_VAR


    METHOD PROTECTED OVERRIDE Main
        _testCyclinder.Run(THIS,  
                            WORD#64,                           
                            REF(_homeSensor), 
                            REF(_workSensor), 
                            REF(_moveHomeSignal), 
                            REF(_moveWorkSignal));

        IF(_manualControl) THEN
            _testCyclinder.ActivateManualControl();
        END_IF;    

        _data[0].%X0 := _moveHomeSignal;
        _data[0].%X1 := _moveWorkSignal;
        _data[0].%X2 := _moveHomeSignal;
        _data[0].%X3 := _moveWorkSignal;
        _data[0].%X4 := _moveHomeSignal;
        _data[0].%X5 := _moveWorkSignal;
        _data[0].%X6 := _moveHomeSignal;
        _data[0].%X7 := _moveWorkSignal;
        _retvalAventics := Siemens.Simatic.S71500.DistributedIO.WriteData(HwIdentifiers#aventics_Valve_driver_4_valves_1_Valve_driver_4_valves_4_HwID,_data);
        _retvalFesto := Siemens.Simatic.S71500.DistributedIO.WriteData(HwIdentifiers#festocpx_MPA1S_VMPA1_FB_EMG_8_1_MPA1G_VMPA1_FB_EMG_8_8DO_HwID,_data);
        _retvalET200 := Siemens.Simatic.S71500.DistributedIO.WriteData(HwIdentifiers#et200sp_1_DQ_ST_1_DQ_8x24VDC_0_5A_ST_V1_1_HwID,_data);

    END_METHOD
END_CLASS