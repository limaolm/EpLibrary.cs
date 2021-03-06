// 이 파일은 이 프로젝트에 적용되는 SuppressMessage 특성을 유지 관리하기 위해 
// 코드 분석에서 사용하는 파일입니다.
// 프로젝트 수준 비표시 오류(Suppression)는 대상이 없거나 특정 대상에 
// 지정되며 네임스페이스, 형식, 멤버 등으로 범위가 지정됩니다.
//
// 이 파일에 비표시 오류(Suppression)를 추가하려면 
// 코드 분석 결과에서 메시지를 마우스 오른쪽 단추로 클릭하고 "메시지 표시 안 함"을 가리킨 후 
// "비표시 오류(Suppression) 파일"을 클릭합니다.
// 이 파일에 수동으로 비표시 오류(Suppression)를 추가할 필요가 없습니다.

[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2202:개체를 여러 번 삭제하지 마십시오.", Scope = "member", Target = "EpLibrary.cs.DynamicJson.#CreateJsonString(System.Xml.Linq.XStreamingElement)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1063:ImplementIDisposableCorrectly", Scope = "type", Target = "EpLibrary.cs.CrcCalculatorStream")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1063:ImplementIDisposableCorrectly", Scope = "member", Target = "EpLibrary.cs.CrcCalculatorStream.#System.IDisposable.Dispose()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1065:DoNotRaiseExceptionsInUnexpectedLocations", Scope = "member", Target = "EpLibrary.cs.DeflateStream.#Length")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2202:개체를 여러 번 삭제하지 마십시오.", Scope = "member", Target = "EpLibrary.cs.GZip.#Compress(System.Byte[])")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2202:개체를 여러 번 삭제하지 마십시오.", Scope = "member", Target = "EpLibrary.cs.GZip.#Compress(System.Byte[],System.Int32,System.Int32)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1065:DoNotRaiseExceptionsInUnexpectedLocations", Scope = "member", Target = "EpLibrary.cs.GZipStream.#Length")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2237:MarkISerializableTypesWithSerializable", Scope = "type", Target = "EpLibrary.cs.ZlibException")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1063:ImplementIDisposableCorrectly", Scope = "member", Target = "EpLibrary.cs.ParallelDeflateOutputStream.#Dispose()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2213:DisposableFieldsShouldBeDisposed", MessageId = "_newlyCompressedBlob", Scope = "member", Target = "EpLibrary.cs.ParallelDeflateOutputStream.#Dispose(System.Boolean)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2202:개체를 여러 번 삭제하지 마십시오.", Scope = "member", Target = "EpLibrary.cs.BinarySerializer.#FinishedSerializing()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2202:개체를 여러 번 삭제하지 마십시오.", Scope = "member", Target = "EpLibrary.cs.BinarySerializer.#StartDeserializing()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2237:MarkISerializableTypesWithSerializable", Scope = "type", Target = "EpLibrary.cs.SilverlightSerializer+MissingConstructorException")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1001:TypesThatOwnDisposableFieldsShouldBeDisposable", Scope = "type", Target = "EpLibrary.cs.BinarySerializer")]
