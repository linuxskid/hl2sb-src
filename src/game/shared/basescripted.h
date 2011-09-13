//========= Copyright � 1996-2005, Valve Corporation, All rights reserved. ============//
//
// Purpose: 
//
// $NoKeywords: $
//
//=============================================================================//

#ifndef BASESCRIPTED_H
#define BASESCRIPTED_H

#include "predictable_entity.h"
#include "baseentity_shared.h"

#if defined( CLIENT_DLL )
#define CBaseScripted C_BaseScripted

#endif 

class CBaseScripted : /* public CBaseEntity */ public CBaseAnimating
{
public:
	// DECLARE_CLASS( CBaseScripted, CBaseEntity );
	DECLARE_CLASS( CBaseScripted, CBaseAnimating );
	DECLARE_PREDICTABLE();
	DECLARE_NETWORKCLASS();

	CBaseScripted();
	~CBaseScripted();

	bool	IsScripted( void ) const { return true; }
	
	// CBaseEntity overrides.
public:
	// void	Think();	
	void	ScriptedThink();	

	// void	Spawn( void );
	void	Precache( void );
	void	InitScriptedEntity( void );

	virtual void VPhysicsUpdate( IPhysicsObject *pPhysics );

#ifdef CLIENT_DLL
// IClientThinkable.
public:
	// Called whenever you registered for a think message (with SetNextClientThink).
	virtual void	ClientThink();

	virtual void	OnDataChanged( DataUpdateType_t updateType );
	virtual const char *GetScriptedClassname( void );
#endif

	void Use( CBaseEntity *pActivator, CBaseEntity *pCaller, USE_TYPE useType, float value );

private:
	CBaseScripted( const CBaseScripted & ); // not defined, not accessible

	CNetworkString( m_iScriptedClassname, 255 );
};

void RegisterScriptedBaseEntity( const char *szClassname );
void ResetEntityFactoryDatabase( void );

#endif

