using System;
using System.Collections.Generic;
using System.Text;

namespace ChaseAPIExample
{
    public class Geometry
    {
        public string type { get; set; }
        public List<List<List<double>>> coordinates { get; set; }
    }

    public class Elevation
    {
        public double value { get; set; }
        public string unitCode { get; set; }
    }

    public class Value
    {
        public string validTime { get; set; }
        public double value { get; set; }
    }

    public class Temperature
    {
        public string sourceUnit { get; set; }
        public string uom { get; set; }
        public List<Value> values { get; set; }
    }

    public class Value2
    {
        public string validTime { get; set; }
        public double value { get; set; }
    }

    public class Dewpoint
    {
        public string sourceUnit { get; set; }
        public string uom { get; set; }
        public List<Value2> values { get; set; }
    }

    public class Value3
    {
        public string validTime { get; set; }
        public double value { get; set; }
    }

    public class MaxTemperature
    {
        public string sourceUnit { get; set; }
        public string uom { get; set; }
        public List<Value3> values { get; set; }
    }

    public class Value4
    {
        public string validTime { get; set; }
        public double value { get; set; }
    }

    public class MinTemperature
    {
        public string sourceUnit { get; set; }
        public string uom { get; set; }
        public List<Value4> values { get; set; }
    }

    public class Value5
    {
        public string validTime { get; set; }
        public int value { get; set; }
    }

    public class RelativeHumidity
    {
        public string sourceUnit { get; set; }
        public string uom { get; set; }
        public List<Value5> values { get; set; }
    }

    public class Value6
    {
        public string validTime { get; set; }
        public double value { get; set; }
    }

    public class ApparentTemperature
    {
        public string sourceUnit { get; set; }
        public string uom { get; set; }
        public List<Value6> values { get; set; }
    }

    public class Value7
    {
        public string validTime { get; set; }
        public double? value { get; set; }
    }

    public class HeatIndex
    {
        public string sourceUnit { get; set; }
        public string uom { get; set; }
        public List<Value7> values { get; set; }
    }

    public class Value8
    {
        public string validTime { get; set; }
        public double? value { get; set; }
    }

    public class WindChill
    {
        public string sourceUnit { get; set; }
        public string uom { get; set; }
        public List<Value8> values { get; set; }
    }

    public class Value9
    {
        public string validTime { get; set; }
        public int value { get; set; }
    }

    public class SkyCover
    {
        public string sourceUnit { get; set; }
        public string uom { get; set; }
        public List<Value9> values { get; set; }
    }

    public class Value10
    {
        public string validTime { get; set; }
        public double value { get; set; }
    }

    public class WindDirection
    {
        public string sourceUnit { get; set; }
        public string uom { get; set; }
        public List<Value10> values { get; set; }
    }

    public class Value11
    {
        public string validTime { get; set; }
        public double value { get; set; }
    }

    public class WindSpeed
    {
        public string sourceUnit { get; set; }
        public string uom { get; set; }
        public List<Value11> values { get; set; }
    }

    public class Value12
    {
        public string validTime { get; set; }
        public double value { get; set; }
    }

    public class WindGust
    {
        public string sourceUnit { get; set; }
        public string uom { get; set; }
        public List<Value12> values { get; set; }
    }

    public class Value14
    {
        public string coverage { get; set; }
        public string weather { get; set; }
        public string intensity { get; set; }
        public object visibility { get; set; }
        public object attributes { get; set; }
    }

    public class Value13
    {
        public string validTime { get; set; }
        public List<Value14> value { get; set; }
    }

    public class Weather
    {
        public List<Value13> values { get; set; }
    }

    public class Hazards
    {
        public List<object> values { get; set; }
    }

    public class Value15
    {
        public string validTime { get; set; }
        public int value { get; set; }
    }

    public class ProbabilityOfPrecipitation
    {
        public string sourceUnit { get; set; }
        public string uom { get; set; }
        public List<Value15> values { get; set; }
    }

    public class Value16
    {
        public string validTime { get; set; }
        public double value { get; set; }
    }

    public class QuantitativePrecipitation
    {
        public string sourceUnit { get; set; }
        public string uom { get; set; }
        public List<Value16> values { get; set; }
    }

    public class Value17
    {
        public string validTime { get; set; }
        public int value { get; set; }
    }

    public class IceAccumulation
    {
        public string sourceUnit { get; set; }
        public string uom { get; set; }
        public List<Value17> values { get; set; }
    }

    public class Value18
    {
        public string validTime { get; set; }
        public double value { get; set; }
    }

    public class SnowfallAmount
    {
        public string sourceUnit { get; set; }
        public string uom { get; set; }
        public List<Value18> values { get; set; }
    }

    public class SnowLevel
    {
        public string sourceUnit { get; set; }
        public string uom { get; set; }
        public List<object> values { get; set; }
    }

    public class Value19
    {
        public string validTime { get; set; }
        public double value { get; set; }
    }

    public class CeilingHeight
    {
        public string sourceUnit { get; set; }
        public string uom { get; set; }
        public List<Value19> values { get; set; }
    }

    public class Value20
    {
        public string validTime { get; set; }
        public double value { get; set; }
    }

    public class Visibility
    {
        public string sourceUnit { get; set; }
        public string uom { get; set; }
        public List<Value20> values { get; set; }
    }

    public class Value21
    {
        public string validTime { get; set; }
        public double value { get; set; }
    }

    public class TransportWindSpeed
    {
        public string sourceUnit { get; set; }
        public string uom { get; set; }
        public List<Value21> values { get; set; }
    }

    public class Value22
    {
        public string validTime { get; set; }
        public double value { get; set; }
    }

    public class TransportWindDirection
    {
        public string sourceUnit { get; set; }
        public string uom { get; set; }
        public List<Value22> values { get; set; }
    }

    public class Value23
    {
        public string validTime { get; set; }
        public double value { get; set; }
    }

    public class MixingHeight
    {
        public string sourceUnit { get; set; }
        public string uom { get; set; }
        public List<Value23> values { get; set; }
    }

    public class Value24
    {
        public string validTime { get; set; }
        public int value { get; set; }
    }

    public class HainesIndex
    {
        public List<Value24> values { get; set; }
    }

    public class Value25
    {
        public string validTime { get; set; }
        public int value { get; set; }
    }

    public class LightningActivityLevel
    {
        public List<Value25> values { get; set; }
    }

    public class TwentyFootWindSpeed
    {
        public string sourceUnit { get; set; }
        public string uom { get; set; }
        public List<object> values { get; set; }
    }

    public class TwentyFootWindDirection
    {
        public string sourceUnit { get; set; }
        public string uom { get; set; }
        public List<object> values { get; set; }
    }

    public class WaveHeight
    {
        public object sourceUnit { get; set; }
        public List<object> values { get; set; }
    }

    public class WavePeriod
    {
        public object sourceUnit { get; set; }
        public List<object> values { get; set; }
    }

    public class WaveDirection
    {
        public object sourceUnit { get; set; }
        public List<object> values { get; set; }
    }

    public class PrimarySwellHeight
    {
        public object sourceUnit { get; set; }
        public List<object> values { get; set; }
    }

    public class PrimarySwellDirection
    {
        public object sourceUnit { get; set; }
        public List<object> values { get; set; }
    }

    public class SecondarySwellHeight
    {
        public object sourceUnit { get; set; }
        public List<object> values { get; set; }
    }

    public class SecondarySwellDirection
    {
        public object sourceUnit { get; set; }
        public List<object> values { get; set; }
    }

    public class WavePeriod2
    {
        public object sourceUnit { get; set; }
        public List<object> values { get; set; }
    }

    public class WindWaveHeight
    {
        public object sourceUnit { get; set; }
        public List<object> values { get; set; }
    }

    public class DispersionIndex
    {
        public List<object> values { get; set; }
    }

    public class Pressure
    {
        public List<object> values { get; set; }
    }

    public class ProbabilityOfTropicalStormWinds
    {
        public string sourceUnit { get; set; }
        public string uom { get; set; }
        public List<object> values { get; set; }
    }

    public class ProbabilityOfHurricaneWinds
    {
        public string sourceUnit { get; set; }
        public string uom { get; set; }
        public List<object> values { get; set; }
    }

    public class PotentialOf15mphWinds
    {
        public List<object> values { get; set; }
    }

    public class PotentialOf25mphWinds
    {
        public List<object> values { get; set; }
    }

    public class PotentialOf35mphWinds
    {
        public List<object> values { get; set; }
    }

    public class PotentialOf45mphWinds
    {
        public List<object> values { get; set; }
    }

    public class PotentialOf20mphWindGusts
    {
        public List<object> values { get; set; }
    }

    public class PotentialOf30mphWindGusts
    {
        public List<object> values { get; set; }
    }

    public class PotentialOf40mphWindGusts
    {
        public List<object> values { get; set; }
    }

    public class PotentialOf50mphWindGusts
    {
        public List<object> values { get; set; }
    }

    public class PotentialOf60mphWindGusts
    {
        public List<object> values { get; set; }
    }

    public class GrasslandFireDangerIndex
    {
        public List<object> values { get; set; }
    }

    public class ProbabilityOfThunder
    {
        public List<object> values { get; set; }
    }

    public class DavisStabilityIndex
    {
        public List<object> values { get; set; }
    }

    public class AtmosphericDispersionIndex
    {
        public List<object> values { get; set; }
    }

    public class LowVisibilityOccurrenceRiskIndex
    {
        public List<object> values { get; set; }
    }

    public class Stability
    {
        public List<object> values { get; set; }
    }

    public class RedFlagThreatIndex
    {
        public List<object> values { get; set; }
    }

    public class Properties
    {
        public string id { get; set; }
        public string type { get; set; }
        public DateTime updateTime { get; set; }
        public string validTimes { get; set; }
        public Elevation elevation { get; set; }
        public string forecastOffice { get; set; }
        public string gridId { get; set; }
        public string gridX { get; set; }
        public string gridY { get; set; }
        public Temperature temperature { get; set; }
        public Dewpoint dewpoint { get; set; }
        public MaxTemperature maxTemperature { get; set; }
        public MinTemperature minTemperature { get; set; }
        public RelativeHumidity relativeHumidity { get; set; }
        public ApparentTemperature apparentTemperature { get; set; }
        public HeatIndex heatIndex { get; set; }
        public WindChill windChill { get; set; }
        public SkyCover skyCover { get; set; }
        public WindDirection windDirection { get; set; }
        public WindSpeed windSpeed { get; set; }
        public WindGust windGust { get; set; }
        public Weather weather { get; set; }
        public Hazards hazards { get; set; }
        public ProbabilityOfPrecipitation probabilityOfPrecipitation { get; set; }
        public QuantitativePrecipitation quantitativePrecipitation { get; set; }
        public IceAccumulation iceAccumulation { get; set; }
        public SnowfallAmount snowfallAmount { get; set; }
        public SnowLevel snowLevel { get; set; }
        public CeilingHeight ceilingHeight { get; set; }
        public Visibility visibility { get; set; }
        public TransportWindSpeed transportWindSpeed { get; set; }
        public TransportWindDirection transportWindDirection { get; set; }
        public MixingHeight mixingHeight { get; set; }
        public HainesIndex hainesIndex { get; set; }
        public LightningActivityLevel lightningActivityLevel { get; set; }
        public TwentyFootWindSpeed twentyFootWindSpeed { get; set; }
        public TwentyFootWindDirection twentyFootWindDirection { get; set; }
        public WaveHeight waveHeight { get; set; }
        public WavePeriod wavePeriod { get; set; }
        public WaveDirection waveDirection { get; set; }
        public PrimarySwellHeight primarySwellHeight { get; set; }
        public PrimarySwellDirection primarySwellDirection { get; set; }
        public SecondarySwellHeight secondarySwellHeight { get; set; }
        public SecondarySwellDirection secondarySwellDirection { get; set; }
        public WavePeriod2 wavePeriod2 { get; set; }
        public WindWaveHeight windWaveHeight { get; set; }
        public DispersionIndex dispersionIndex { get; set; }
        public Pressure pressure { get; set; }
        public ProbabilityOfTropicalStormWinds probabilityOfTropicalStormWinds { get; set; }
        public ProbabilityOfHurricaneWinds probabilityOfHurricaneWinds { get; set; }
        public PotentialOf15mphWinds potentialOf15mphWinds { get; set; }
        public PotentialOf25mphWinds potentialOf25mphWinds { get; set; }
        public PotentialOf35mphWinds potentialOf35mphWinds { get; set; }
        public PotentialOf45mphWinds potentialOf45mphWinds { get; set; }
        public PotentialOf20mphWindGusts potentialOf20mphWindGusts { get; set; }
        public PotentialOf30mphWindGusts potentialOf30mphWindGusts { get; set; }
        public PotentialOf40mphWindGusts potentialOf40mphWindGusts { get; set; }
        public PotentialOf50mphWindGusts potentialOf50mphWindGusts { get; set; }
        public PotentialOf60mphWindGusts potentialOf60mphWindGusts { get; set; }
        public GrasslandFireDangerIndex grasslandFireDangerIndex { get; set; }
        public ProbabilityOfThunder probabilityOfThunder { get; set; }
        public DavisStabilityIndex davisStabilityIndex { get; set; }
        public AtmosphericDispersionIndex atmosphericDispersionIndex { get; set; }
        public LowVisibilityOccurrenceRiskIndex lowVisibilityOccurrenceRiskIndex { get; set; }
        public Stability stability { get; set; }
        public RedFlagThreatIndex redFlagThreatIndex { get; set; }
    }

    public class RootObject
    {
        public List<object> context { get; set; }
        public string id { get; set; }
        public string type { get; set; }
        public Geometry geometry { get; set; }
        public Properties properties { get; set; }
    }
}
